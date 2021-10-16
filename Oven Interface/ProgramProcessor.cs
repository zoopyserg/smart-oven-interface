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
        
        public long ExpectedTemperature { get; set; }

        public ProgramProcessor(Dashboard form)
        {
            this.form = form;
            timer = new System.Timers.Timer();
            timer.Interval = 1000; // todo: make it an adjustable setting.
            minutesPassed = 0;
            timer.Elapsed += OnTimeEvent;
        }
        
        public void Start(int activeProgramId)
        {
            runningProgram = BreadsController.Index().Where(o => o.Id == activeProgramId).First();
            minutesPassed = 0;
            StartTimer(activeProgramId);
        }

        public void Stop()
        {
            CommitProgramFinilization();
            timer.Stop();
        }

        public void Pause()
        {
            CommitProgramFinilization();
            timer.Stop();
        }

        public void Continue()
        {
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
            LaunchInstancesController.Create(activeProgramId); // for now requires UpdateBinding();
            form.UpdateBinding();
            form.UpdateActiveProgramNameLabelAsync(form, runningProgram.Name);
            timer.Start();
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            form.Invoke(new Action(() =>
            {
                if (minutesPassed >= runningProgram.Duration)
                {
                    CommitProgramFinilization();
                    timer.Stop();
                }
                else
                {
                    minutesPassed += 1;
                    ExpectedTemperature = runningProgram.CurrentExpectedTemperature(minutesPassed);
                    form.UpdateExpectedTemperatureAsync(form, ExpectedTemperature);
                    
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
                    form.UpdateTimeLeftAsync(form, (runningProgram.Duration - minutesPassed).ToString());
                }
            }));
        }

        public void CommitProgramFinilization()
        {
            if (runningProgram != null)
            {
                form.UpdateStatusListBox($"Програму {runningProgram.Name} завершено");
                BreadsController.Finish(runningProgram.Id);
                form.UpdateProgressBarAsync(form, 0, 0, runningProgram.Duration);
                runningProgram = null;
                form.UpdateTimeLeftAsync(form, "-");
                form.UpdateBinding();
            }
        }
    }
}
