using Oven_Interface.Controllers;
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
        public int minutesPassed { get; set; }
        public Bread runningProgram { get; set; }
        public Dashboard form { get; set; }
        public bool IsRunning { get; set; }

        public long ExpectedTemperature { get; set; }

        public ProgramProcessor(Dashboard form)
        {
            this.form = form;
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            minutesPassed = 0;
            timer.Elapsed += OnTimeEvent;
            this.IsRunning = false;
        }
        
        public void Start(int activeProgramId)
        {
            minutesPassed = 0;
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
            DoSameThingOnZerothSecond();
            timer.Start();
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            if (runningProgram != null)
            {
                form.Invoke(new Action(() =>
                {
                    if (minutesPassed >= runningProgram.Duration)
                    {
                        CommitProgramFinilization();
                    }
                    else
                    {
                        minutesPassed += 1;
                        ExpectedTemperature = runningProgram.CurrentExpectedTemperature(minutesPassed);
                        form.UpdateExpectedTemperatureAsync(form, $"{ ExpectedTemperature.ToString() } C");

                        if (form.CurrentTemperature < ExpectedTemperature)
                        {
                            form.ArduinoConnection.TurnOnPin(Properties.Settings.Default.pinTemperatureRelay);
                        }
                        else
                        {
                            form.ArduinoConnection.TurnOffPin(Properties.Settings.Default.pinTemperatureRelay);
                        }

                        BreadsController.Update(runningProgram.Id, minutesPassed);
                        form.UpdateProgressBarAsync(form, 0, minutesPassed, runningProgram.Duration);
                        form.UpdateTimeLeftAsync(form, ((runningProgram.Duration - minutesPassed)/60).ToString());
                    }
                }));
            }
        }

        private void DoSameThingOnZerothSecond()
        {
            if (runningProgram != null)
            {
                form.Invoke(new Action(() =>
                {
                    if (minutesPassed >= runningProgram.Duration)
                    {
                        CommitProgramFinilization();
                    }
                    else
                    {
                        minutesPassed += 1;
                        ExpectedTemperature = runningProgram.CurrentExpectedTemperature(minutesPassed);
                        form.UpdateExpectedTemperatureAsync(form, $"{ ExpectedTemperature.ToString() } C");

                        if (form.CurrentTemperature < ExpectedTemperature)
                        {
                            form.ArduinoConnection.TurnOnPin(Properties.Settings.Default.pinTemperatureRelay);
                        }
                        else
                        {
                            form.ArduinoConnection.TurnOffPin(Properties.Settings.Default.pinTemperatureRelay);
                        }

                        BreadsController.Update(runningProgram.Id, minutesPassed);
                        form.UpdateProgressBarAsync(form, 0, minutesPassed, runningProgram.Duration);
                        form.UpdateTimeLeftAsync(form, ((runningProgram.Duration - minutesPassed) / 60).ToString());
                    }
                }));
            }
        }

        public void CommitProgramFinilization()
        {
            if (IsRunning)
            {
                timer.Stop();
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
                    form.ArduinoConnection.TurnOffAllPins();
                }
            }
        }

        public void CommitProgramPausing()
        {
            timer.Stop();
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
        }
    }
}
