using Oven_Interface.Controllers;
using Oven_Interface.Models;
using Oven_Interface.Views;
using Solid.Arduino;
using Solid.Arduino.Firmata;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace Oven_Interface
{
    public partial class Dashboard : Form

    {
        List<Bread> breads = new List<Bread>();
        List<TemperaturePoint> temperaturePoints = new List<TemperaturePoint>();
        List<PressurePoint> pressurePoints = new List<PressurePoint>();
        List<ValvePoint> valvePoints = new List<ValvePoint>();        
        List<LaunchInstance> launchInstances = new List<LaunchInstance>();

        public List<StatusLine> statusLines { get; set; }

        System.Timers.Timer timer;
        int minutesPassed;
        Bread runningProgram;

        public long CurrentSensorValue { get; set; }
        public long CurrentTemperature { get; set; }
        public long ExpectedTemperature { get; set; }

        public ArduinoAccess ArduinoConnection { get; set; }

        public Dashboard()
        {
            this.statusLines = new List<StatusLine>();
            
            InitializeComponent();

            this.ArduinoConnection = new ArduinoAccess(this);

            UpdateBinding();
        }
        private void UpdateBinding(bool refreshEverything = true)
        {
            int persistedIndex = -1;
            
            if (refreshEverything)
            {
                breads = BreadsController.Index();
            }
            
            if ((programsListBox.SelectedIndex < 0) || (programsListBox.SelectedIndex > (breads.Count - 1)))
            {
                if (breads.Count > 0)
                {
                    persistedIndex = 0;
                } else
                {
                    persistedIndex = -1;
                }
            } else
            {
                persistedIndex = programsListBox.SelectedIndex;
            }

            if ((breads.Count > 0) && (persistedIndex > -1))
            {
                int selectedBreadId = breads[persistedIndex].Id;
                temperaturePoints = TemperaturePointsController.Index(selectedBreadId);
                pressurePoints = PressurePointsController.Index(selectedBreadId);
                valvePoints = ValvePointsController.Index(selectedBreadId);
                launchInstances = LaunchInstancesController.Index(selectedBreadId);
            }

            UpdateProgramsListBox();
            UpdatePressurePointsListBox();
            UpdateTemperaturePointsListBox();
            UpdateValvePointsListBox();
            UpdateHistoryListBox();

            UpdatePressurePointsChart();
            UpdateValvePointsChart();
            UpdateTemperaturePointsChart();

            if (refreshEverything)
            {
                programsListBox.SelectedIndex = persistedIndex;
            }
        }

        private void UpdateProgramsListBox()
        {
            programsListBox.DataSource = null;
            programsListBox.DataSource = breads;
            programsListBox.DisplayMember = "DisplayString";
        }

        private void UpdateHistoryListBox()
        {
            historyListBox.DataSource = null;
            historyListBox.DataSource = launchInstances;
            historyListBox.DisplayMember = "DisplayString";
        }

        private void UpdatePressurePointsListBox()
        {
            pressurePointsListBox.DataSource = null;
            pressurePointsListBox.DataSource = pressurePoints;
            pressurePointsListBox.DisplayMember = "DisplayString";
        }
        private void UpdateTemperaturePointsListBox()
        {
            temperaturePointsListBox.DataSource = null;
            temperaturePointsListBox.DataSource = temperaturePoints;
            temperaturePointsListBox.DisplayMember = "DisplayString";
        }
        private void UpdateValvePointsListBox()
        {
            valvePointsListBox.DataSource = null;
            valvePointsListBox.DataSource = valvePoints;
            valvePointsListBox.DisplayMember = "DisplayString";
        }

        public void UpdateStatusListBox(string name)
        {
            StatusLine statusLine = new StatusLine();
            statusLine.Name = name;
            statusLine.CreatedAt = DateTime.Now;
            this.statusLines.Add(statusLine);
            statusListBox.DataSource = null;
            statusListBox.DataSource = this.statusLines;
            statusListBox.DisplayMember = "DisplayString";
        }

        public void UpdateStatusListBoxAsync(object sender, FirmataEventArgs<AnalogState> eventArgs)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<object, FirmataEventArgs<AnalogState>>(UpdateStatusListBoxAsync), sender, eventArgs);
                return;
            }

            this.CurrentSensorValue = eventArgs.Value.Level;
            sensorValueLabel.Text = $"{this.CurrentSensorValue.ToString()}";
            this.CurrentTemperature = Properties.Settings.Default.temperatureCoefficientA * this.CurrentSensorValue * this.CurrentSensorValue + Properties.Settings.Default.temperatureCoefficientB * this.CurrentSensorValue + Properties.Settings.Default.temperatureCoefficientC;

            temperatureLabel.Text = $"{ this.CurrentTemperature.ToString()} C";
        }

        private void UpdateTemperaturePointsChart()
        {
            chartTemperatures.DataSource = temperaturePoints;
            chartTemperatures.DataBind();
        }

        private void UpdatePressurePointsChart()
        {
            pressuresChart.DataSource = pressurePoints;
            pressuresChart.DataBind();
        }

        private void UpdateValvePointsChart()
        {
            valveChart.DataSource = valvePoints;
            valveChart.DataBind();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(13);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(13);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateBinding();

            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            minutesPassed = 0;
            timer.Elapsed += OnTimeEvent;
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                if (minutesPassed >= runningProgram.Duration)
                {
                    CommitProgramFinilization();
                    timer.Stop();
                }
                else
                {
                    // increase timer
                    minutesPassed += 1;
                    // turn on the relay if needed
                    ExpectedTemperature = runningProgram.CurrentExpectedTemperature(minutesPassed);
                    // todo: histerisis (maybe add a couple degrees to the expected temperature)
                    expectedTemperatureLabel.Text = $"{ ExpectedTemperature.ToString() } C";

                    if (this.CurrentTemperature < this.ExpectedTemperature)
                    {
                        this.ArduinoConnection.TurnOnPin(3);
                    } else
                    {
                        this.ArduinoConnection.TurnOffPin(3);
                    }

                    // perform temperature display
                    BreadsController.Update(runningProgram.Id, minutesPassed);
                    progressBar1.Minimum = 0;
                    progressBar1.Maximum = runningProgram.Duration;
                    progressBar1.Value = minutesPassed;
                    minutesLeftLabel.Text = (runningProgram.Duration - minutesPassed).ToString();
                    //int persistedIndex = programsListBox.SelectedIndex;
                    //breads = BreadsController.Index();
                    //UpdateBinding(false);
                    //programsListBox.SelectedIndex = persistedIndex;
                }
            }));
        }

        public void CommitProgramFinilization()
        {
            UpdateStatusListBox($"Програму {runningProgram.Name} завершено");
            BreadsController.Finish(runningProgram.Id);
            runningProgram = null;
            minutesPassed = 0;
            progressBar1.Value = 0;
            LaunchedProgramLabel.Text = "-";
            UpdateBinding();
        }

        private void createBread_Click(object sender, EventArgs e)
        {
            BreadsController.Create(newProgramNameTextBox.Text);
            newProgramNameTextBox.Text = "";
            UpdateBinding();
        }

        private void programsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBinding(false);
        }

        private void createTemperatureButton_Click(object sender, EventArgs e)
        {
            int persistedIndex = programsListBox.SelectedIndex;
            TemperaturePointsController.Create(breads[persistedIndex].Id, Decimal.ToInt32(newTemperaturePointMinuteTextBox.Value), Decimal.ToInt32(newTemperaturePointValueTextBox.Value));
            newTemperaturePointMinuteTextBox.Value = 0;
            newTemperaturePointValueTextBox.Value = 0;
            UpdateBinding();
        }

        private void buttonDeleteProgram_Click(object sender, EventArgs e)
        {
            BreadsController.Delete(breads[programsListBox.SelectedIndex].Id);
            UpdateBinding();
        }

        private void deleteTemperaturePointButton_Click(object sender, EventArgs e)
        {
            TemperaturePointsController.Delete(temperaturePoints[temperaturePointsListBox.SelectedIndex].Id);
            UpdateBinding();
        }

        private void buttonPreviousProgram_Click(object sender, EventArgs e)
        {
            selectPreviousElementInTheList(programsListBox);
        }

        private void nextProgram_Click(object sender, EventArgs e)
        {
            selectNextElementInTheList<Bread>(programsListBox, breads);
        }

        private void previousTemperaturePointButton_Click(object sender, EventArgs e)
        {
            selectPreviousElementInTheList(temperaturePointsListBox);
        }

        private void nextTemperaturePointButton_Click(object sender, EventArgs e)
        {
            selectNextElementInTheList<TemperaturePoint>(temperaturePointsListBox, temperaturePoints);
        }

        private void selectPreviousElementInTheList(ListBox listBox)
        {
            int persistedIndex = listBox.SelectedIndex;
            if (persistedIndex > 0)
            {
                listBox.SelectedIndex = persistedIndex - 1;
            }
        }

        private void selectNextElementInTheList<T>(ListBox listBox, List<T> relatedVariable)
        {
            int persistedIndex = listBox.SelectedIndex;
            if (persistedIndex < (relatedVariable.Count - 1))
            {
                listBox.SelectedIndex = persistedIndex + 1;
            }
        }

        private void startProgramButton_Click(object sender, EventArgs e)
        {
            // создать инстанс запуска. для начала. факт запуска.
            int persistedIndex = programsListBox.SelectedIndex;
            runningProgram = breads[persistedIndex];
            runningProgram.TemperaturePoints = TemperaturePointsController.Index(runningProgram.Id);
            runningProgram.PressurePoints = PressurePointsController.Index(runningProgram.Id);
            runningProgram.ValvePoints = ValvePointsController.Index(runningProgram.Id);
            LaunchInstancesController.Create(runningProgram.Id);
            LaunchedProgramLabel.Text = runningProgram.Name;
            UpdateBinding();
            timer.Start();

            // и каждую секунду обновлять статус запуска (сколько минут прошло).
            // и выставлять тот градус который надо выставлять согласно последней минуте.
            // узнать сколько времени должен играть таймер (минуту последней температуры)
            // стартануть таймер
            // а таймер это воркер который смотрит сколько времени прошло и ... или как там я планировал...
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop();
            Application.DoEvents();
        }

        private void stopProgramButton_Click(object sender, EventArgs e)
        {
            CommitProgramFinilization();
            timer.Stop();
        }

        private void pauseProgramButton_Click(object sender, EventArgs e)
        {
            CommitProgramFinilization();
            timer.Stop();
        }

        private void continueProgramButton_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void previousPressurePointButton_Click(object sender, EventArgs e)
        {
            selectPreviousElementInTheList(pressurePointsListBox);
        }

        private void nextPressurePointButton_Click(object sender, EventArgs e)
        {
            selectNextElementInTheList<PressurePoint>(pressurePointsListBox, pressurePoints);
        }

        private void deletePressurePointButton_Click(object sender, EventArgs e)
        {
            PressurePointsController.Delete(pressurePoints[pressurePointsListBox.SelectedIndex].Id);
            UpdateBinding();
        }

        private void previousValvePointButton_Click(object sender, EventArgs e)
        {
            selectPreviousElementInTheList(valvePointsListBox);
        }

        private void nextValvePointButton_Click(object sender, EventArgs e)
        {
            selectNextElementInTheList<ValvePoint>(valvePointsListBox, valvePoints);
        }

        private void deleteValvePointButton_Click(object sender, EventArgs e)
        {
            ValvePointsController.Delete(valvePoints[valvePointsListBox.SelectedIndex].Id);
            UpdateBinding();
        }

        private void createPressurePointButton_Click(object sender, EventArgs e)
        {
            int persistedIndex = programsListBox.SelectedIndex;
            PressurePointsController.Create(breads[persistedIndex].Id, Decimal.ToInt32(newPressurePointMinuteTextBox.Value), Decimal.ToInt32(newPressurePointValueTextBox.Value));
            newPressurePointMinuteTextBox.Value = 0;
            newPressurePointValueTextBox.Value = 0;
            UpdateBinding();
        }

        private void createValvePointButton_Click(object sender, EventArgs e)
        {
            int persistedIndex = programsListBox.SelectedIndex;
            ValvePointsController.Create(breads[persistedIndex].Id, Decimal.ToInt32(newValvePointMinuteTextBox.Value), Decimal.ToInt32(newValvePointValueTextBox.Value));
            newValvePointMinuteTextBox.Value = 0;
            newValvePointValueTextBox.Value = 0;
            UpdateBinding();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(4);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(4);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(3);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(2);
        }

        private void перевіркаПінівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form pinTesting = new PinTesting(this.ArduinoConnection);
            pinTesting.Show();
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void оновитиІнформаціюПроДоступніПіниToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.ReportCapabilities();
        }

        private void оновитиІнформаціюПроДоступніРежимиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateBinding();
        }

        private void калібруванняТермодатчикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form temperatureCalibration = new TemperatureCalibration(this);
            temperatureCalibration.Show();
        }
    }
}
