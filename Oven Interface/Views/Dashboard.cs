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

        public ArduinoAccess ArduinoConnection { get; set; }
        public ProgramProcessor programProcessor { get; set; }
        public long CurrentSensorValue { get; set; }
        public long CurrentTemperature { get; set; }

        public Dashboard()
        {
            this.statusLines = new List<StatusLine>();
            
            InitializeComponent();

            this.ArduinoConnection = new ArduinoAccess(this);
            this.programProcessor = new ProgramProcessor(this);

            EnableDisableContinueButton();
            EnableDisableStartButton();
            EnableDisablePauseButton();
            EnableDisableStopButton();

            UpdateBinding();
        }
        public void UpdateBinding(bool refreshEverything = true)
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

        public void EnableDisableContinueButton()
        {
            continueProgramButton.Enabled = (Properties.Settings.Default.ActiveProgramId >= 0 && !programProcessor.IsRunning);
        }

        public void EnableDisableStartButton()
        {
            startProgramButton.Enabled = (!programProcessor.IsRunning);
        }

        public void EnableDisablePauseButton()
        {
            pauseProgramButton.Enabled = programProcessor.IsRunning;
        }

        public void EnableDisableStopButton()
        {
            stopProgramButton.Enabled = programProcessor.IsRunning;
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
            this.CurrentTemperature = Decimal.ToInt32(Properties.Settings.Default.temperatureCoefficientA * this.CurrentSensorValue * this.CurrentSensorValue + Properties.Settings.Default.temperatureCoefficientB * this.CurrentSensorValue + Properties.Settings.Default.temperatureCoefficientC);

            temperatureLabel.Text = $"{ this.CurrentTemperature.ToString()} C";
        }

        public void UpdateActiveProgramNameLabelAsync(object sender, string programName)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<object, string>(UpdateActiveProgramNameLabelAsync), sender, programName);
                return;
            }

            LaunchedProgramLabel.Text = programName;
        }

        public void UpdateProgressBarAsync(object sender, int minimum, int passed, int maximum)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<object, int, int, int>(UpdateProgressBarAsync), sender, minimum, passed, maximum);
                return;
            }

            progressBar1.Minimum = minimum;
            progressBar1.Maximum = maximum;
            progressBar1.Value = passed;

        }

        public void UpdateTimeLeftAsync(object sender, string text)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<object, string>(UpdateTimeLeftAsync), sender, text);
                return;
            }

            minutesLeftLabel.Text = text;
        }

        public void UpdateExpectedTemperatureAsync(object sender, string temperature)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<object, string>(UpdateExpectedTemperatureAsync), sender, temperature);
                return;
            }

            expectedTemperatureLabel.Text = temperature;
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

        private int ActiveProgramId()
        {
            int selectedIndex = programsListBox.SelectedIndex;
            int activeId = breads[selectedIndex].Id;
            Properties.Settings.Default.ActiveProgramId = activeId;
            Properties.Settings.Default.Save();
            return activeId;
        }

        private void startProgramButton_Click(object sender, EventArgs e)
        {
            programProcessor.Start(ActiveProgramId());
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            programProcessor.Stop();
            ArduinoConnection.Disconnect();
            Application.DoEvents();
        }

        private void stopProgramButton_Click(object sender, EventArgs e)
        {
            programProcessor.Stop();
        }

        private void pauseProgramButton_Click(object sender, EventArgs e)
        {
            programProcessor.Pause();
        }

        private void continueProgramButton_Click(object sender, EventArgs e)
        {
            programProcessor.Continue();
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

        private void роліПінівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form pinSettings = new PinSettings();
            pinSettings.Show();
        }
    }
}
