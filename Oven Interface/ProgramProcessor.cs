using Oven_Interface.Controllers;
using Oven_Interface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Oven_Interface
{
    public class ProgramProcessor
    {
        public System.Timers.Timer timer { get; set; }
        public System.Timers.Timer turnOffHeatingOperationsTimer { get; set; }
        public System.Timers.Timer canChangeTempTimer { get; set; }
        public System.Timers.Timer stopOpeningValveTimer { get; set; }
        public System.Timers.Timer stopClosingValveTimer { get; set; }
        public int minutesPassed { get; set; }
        public Bread runningProgram { get; set; }
        public Dashboard form { get; set; }
        public bool IsRunning { get; set; }
        public bool canChangeTemp { get; set; }
        public bool canChangeValve { get; set; }
        public bool canChangeWater { get; set; }

        public long ExpectedTemperature { get; set; }
        public ValvePoint ExpectedValvePoint { get; set; }
        public PressurePoint ExpectedWaterPoint { get; set; }
        public long lastProcessedValveMinute { get; set; }
        public long lastProcessedWaterMinute { get; set; }

        public ProgramProcessor(Dashboard form)
        {
            this.form = form;
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            minutesPassed = 0;
            timer.Elapsed += OnTimeEvent;
            this.IsRunning = false;

            turnOffHeatingOperationsTimer = new System.Timers.Timer();
            turnOffHeatingOperationsTimer.Interval = 400; // todo: set duration in settings
            turnOffHeatingOperationsTimer.Elapsed += TurnOffAllHeatingOperations;

            canChangeTempTimer = new System.Timers.Timer();
            canChangeTempTimer.Interval = 2000; // todo: set duration in settings
            canChangeTempTimer.Elapsed += SayTempsCanBeChangedAgain;

            stopOpeningValveTimer = new System.Timers.Timer();
            stopOpeningValveTimer.Elapsed += StopOpeningValve;

            stopClosingValveTimer = new System.Timers.Timer();
            stopClosingValveTimer.Interval = Properties.Settings.Default.timeToFullyOpenVentilationValve + 1000;
            stopClosingValveTimer.Elapsed += StopClosingValve;

            canChangeTemp = true;
            canChangeValve = true;
            canChangeWater = true;
            lastProcessedValveMinute = -1;
            lastProcessedWaterMinute = -1;
        }

        public void Start(int activeProgramId)
        {
            minutesPassed = 0;
            form.CurrentClicks = 0;
            form.ExpectedClicks = 0;
            form.UpdateCurrentClicks("0"); 
            StartTimer(activeProgramId);
        }

        public void Stop()
        {
            CommitProgramFinilization();
        }

        public void Pause()
        {
            CommitProgramPausing();
        }

        public void Continue()
        {   // todo: сделать все ланч инстансы финишд кроме той которую продолжили.
            int activeProgramId = Properties.Settings.Default.ActiveProgramId;
            minutesPassed = LaunchInstancesController.Index(activeProgramId).Where(o => (o.Status != "finished")).First().MinutesPassed;
            StartTimer(activeProgramId);
        }

        private void StartTimer(int activeProgramId)
        {
            runningProgram = BreadsController.Index().Where(o => o.Id == activeProgramId).First();
            runningProgram.TemperaturePoints = TemperaturePointsController.Index(activeProgramId);
            runningProgram.PressurePoints = PressurePointsController.Index(activeProgramId);
            runningProgram.ValvePoints = ValvePointsController.Index(activeProgramId);
            LaunchInstancesController.Create(activeProgramId);
            Properties.Settings.Default.ActiveProgramId = activeProgramId;
            Properties.Settings.Default.Save();
            form.UpdateBinding();
            form.UpdateActiveProgramNameLabelAsync(form, runningProgram.Name);
            IsRunning = true;
            form.EnableDisableContinueButton();
            form.EnableDisableStartButton();
            form.EnableDisablePauseButton();
            form.EnableDisableStopButton();
            canChangeWater = true;
            lastProcessedWaterMinute = -1;

            timer.Start();
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            try
            {


                if (runningProgram != null)
                {
                    this.canChangeTempTimer.Start();
                    form.Invoke(new Action(() =>
                    {
                        if (minutesPassed >= runningProgram.Duration)
                        {
                            CommitProgramFinilization();
                        }
                        else
                        {
                            minutesPassed += 1;

                        // edit temperature
                        ExpectedTemperature = runningProgram.CurrentExpectedTemperature(minutesPassed);
                            form.UpdateExpectedTemperatureAsync(form, $"{ ExpectedTemperature.ToString() } C");

                            if (canChangeTemp)
                            {
                                if (form.CurrentTemperature < ExpectedTemperature)
                                {
                                    form.ArduinoConnection.TurnOnPin(Properties.Settings.Default.temperatureUpPin);
                                    form.ArduinoConnection.TurnOffPin(Properties.Settings.Default.temperatureDownPin);
                                    this.turnOffHeatingOperationsTimer.Start();
                                }
                                else
                                {
                                    form.ArduinoConnection.TurnOffPin(Properties.Settings.Default.temperatureUpPin);
                                    form.ArduinoConnection.TurnOnPin(Properties.Settings.Default.temperatureDownPin);
                                    this.turnOffHeatingOperationsTimer.Start();
                                }

                                this.canChangeTemp = false;
                            }

                        // edit valve

                        ExpectedValvePoint = runningProgram.CurrentExpectedValve(minutesPassed);

                            if (ExpectedValvePoint.Minute != -1 && canChangeValve && ((lastProcessedValveMinute == -1) || (lastProcessedValveMinute != -1 && lastProcessedValveMinute != ExpectedValvePoint.Minute)))
                            {
                                lastProcessedValveMinute = ExpectedValvePoint.Minute;
                                form.ArduinoConnection.TurnOnPin(Properties.Settings.Default.openVentilationPin);
                                form.ArduinoConnection.TurnOffPin(Properties.Settings.Default.closeVentilationPin);
                                this.stopOpeningValveTimer.Interval = Properties.Settings.Default.timeToFullyOpenVentilationValve * ExpectedValvePoint.Value / 100;
                                this.stopOpeningValveTimer.Start();

                                this.canChangeValve = false;
                            }

                        // edit water

                        ExpectedWaterPoint = runningProgram.CurrentExpectedWater(minutesPassed);

                            if (ExpectedWaterPoint.Minute != -1 && canChangeWater && ((lastProcessedWaterMinute == -1) || (lastProcessedWaterMinute != -1 && lastProcessedWaterMinute != ExpectedWaterPoint.Minute)))
                            {
                                form.CurrentClicks = 0;
                                form.ExpectedClicks = Decimal.ToInt32(ExpectedWaterPoint.Value * Properties.Settings.Default.waterClicksPerLiter); // todo: convert liters to clicks, now I just store clicks
                                lastProcessedWaterMinute = ExpectedWaterPoint.Minute;
                                form.ArduinoConnection.TurnOnPin(Properties.Settings.Default.waterSolenoidPin);

                                this.canChangeWater = false;
                            }

                            BreadsController.Update(runningProgram.Id, minutesPassed);
                            form.UpdateProgressBarAsync(form, 0, minutesPassed, runningProgram.Duration);
                            form.UpdateTimeLeftAsync(form, ((runningProgram.Duration - minutesPassed) / 60).ToString());
                        }
                    }));

                }
            } catch
            {
                // nothing
            }
        }

        private void StopOpeningValve(object sender, ElapsedEventArgs e)
        {
            try
            {


                if (runningProgram != null)
                {
                    form.Invoke(new Action(() =>
                    {
                        form.ArduinoConnection.TurnOffPin(Properties.Settings.Default.openVentilationPin);
                        form.ArduinoConnection.TurnOnPin(Properties.Settings.Default.closeVentilationPin);
                        this.stopOpeningValveTimer.Stop();
                        this.stopClosingValveTimer.Start();
                    }));
                }
            } catch
            {

            }
        }

        private void StopClosingValve(object sender, ElapsedEventArgs e)
        {
            try
            {


                if (runningProgram != null)
                {
                    form.Invoke(new Action(() =>
                    {
                        form.ArduinoConnection.TurnOffPin(Properties.Settings.Default.closeVentilationPin);
                        this.canChangeValve = true;
                        this.stopClosingValveTimer.Stop();
                    }));

                }
            } catch
            {

            }
        }

        private void TurnOffAllHeatingOperations(object sender, ElapsedEventArgs e)
        {
            try
            {


                if (runningProgram != null)
                {
                    form.Invoke(new Action(() =>
                    {
                        form.ArduinoConnection.TurnOffPin(Properties.Settings.Default.temperatureDownPin);
                        form.ArduinoConnection.TurnOffPin(Properties.Settings.Default.temperatureUpPin);
                    }));
                }
                this.turnOffHeatingOperationsTimer.Stop();
            } catch
            {

            }
        }

        private void SayTempsCanBeChangedAgain(object sender, ElapsedEventArgs e)
        {
            if (runningProgram != null)
            {
                this.canChangeTemp = true;
                this.canChangeTempTimer.Stop();
            }
        }

        public void CommitProgramFinilization()
        {
            try
            {
                if (IsRunning)
                {
                    timer.Stop();
                    lastProcessedValveMinute = -1;
                    if (runningProgram != null)
                    {
                        form.UpdateStatusListBox($"Програму {runningProgram.Name} завершено");
                        BreadsController.Finish(runningProgram.Id);
                        form.UpdateProgressBarAsync(form, 0, 0, runningProgram.Duration);
                        runningProgram = null;
                        form.UpdateTimeLeftAsync(form, "-");
                        form.UpdateBinding();
                        form.UpdateExpectedTemperatureAsync(form, "-");
                        Properties.Settings.Default.ActiveProgramId = -1;
                        Properties.Settings.Default.Save();
                        IsRunning = false;
                        form.EnableDisableConnectButton();
                        form.EnableDisableContinueButton();
                        form.EnableDisableStartButton();
                        form.EnableDisablePauseButton();
                        form.EnableDisableStopButton();

                        form.CurrentClicks = 0;
                        form.ExpectedClicks = 0;
                        form.UpdateCurrentClicks("0");

                        form.ArduinoConnection.TurnOffAllPins();
                    }
                }
            } catch
            {

            }
        }

        public void CommitProgramPausing()
        {
            try
            {
                timer.Stop();
                turnOffHeatingOperationsTimer.Stop();
                canChangeTempTimer.Stop();
                if (runningProgram != null)
                {
                    form.UpdateStatusListBox($"Програму {runningProgram.Name} поставлено на паузу");
                    BreadsController.Pause(runningProgram.Id);
                    //form.UpdateProgressBarAsync(form, 0, 0, runningProgram.Duration);
                    form.UpdateTimeLeftAsync(form, "-");
                    form.UpdateBinding();
                    form.UpdateExpectedTemperatureAsync(form, "-");
                    IsRunning = false;
                    form.EnableDisableContinueButton();
                    form.EnableDisableStartButton();
                    form.EnableDisablePauseButton();
                    form.EnableDisableStopButton();
                    form.ArduinoConnection.TurnOffAllPins();
                }
            } catch
            {

            }
        }
    }
}
