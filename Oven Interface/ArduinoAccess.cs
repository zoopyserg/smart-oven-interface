using Oven_Interface.Controllers;
using Oven_Interface.Models;
using Solid.Arduino;
using Solid.Arduino.Firmata;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Oven_Interface
{
    public class ArduinoAccess
    {
        public ISerialConnection connection { get; set; }
        public ArduinoSession session { get; set; }
        public IFirmataProtocol firmata { get; set; }
        public Dashboard form { get; set; }
        public long previousWaterSensorLockLevel { get; set; }
        public long previousTemperatureLevel { get; set; }

        public List<int> AvailablePins { get; set; }

        public ArduinoAccess(Dashboard _form)
        {
            form = _form;
            AvailablePins = new List<int>();
        }

        public void Reconnect()
        {
            if (connection != null)
            {
                if (connection != null)
                {
                    ReportConnection();
                    session = new ArduinoSession(connection);
                    firmata = session;
                    firmata.ResetBoard();
                    ReportCapabilities();
                    PerformInitialization();
                    ListenTemperature();

                    form.EnableDisableContinueButton();
                    form.EnableDisableStartButton();
                    form.EnableDisablePauseButton();
                    form.EnableDisableStopButton();
                    form.EnableDisableConnectButton();
                }
                else
                {
                    ReportNoConnection();
                    Thread.Sleep(1000);
                    connection = EnhancedSerialConnection.Find();
                    Reconnect();
                }
            }
            else
            {
                ReportNoConnection();
                Thread.Sleep(1000);
                connection = EnhancedSerialConnection.Find();
                Reconnect();
            }

        }

        private void ReportNoConnection()
        {
            if (connection == null)
                form.UpdateStatusListBox("Немає з'єднання з контролером Arduino. Пробую перепідключитись.");
        }

        private void ReportConnection()
        {
            if (connection != null)
                form.UpdateStatusListBox($"Arduino контролер підключений до порта {connection.PortName}.");
        }

        private void PerformInitialization()
        {
            for (int i = 3; i < 14; i++) // пропускаю 1 и 2 потому что их использует USB порт.
            {
                session.SetDigitalPinMode(i, PinMode.DigitalOutput);
                // посылаю true потому что купил плату которая при LOW включена... пофиксить новой платой.
                session.SetDigitalPin(i, true);
            }
        }

        public void TurnOnPin(int pinNumber)
        {
            session.SetDigitalPin(pinNumber, false); //  посылаю true потому что купил плату которая при LOW включена... пофиксить новой платой.
        }

        public void TurnOffPin(int pinNumber)
        {
            session.SetDigitalPin(pinNumber, true); //  посылаю true потому что купил плату которая при LOW включена... пофиксить новой платой.
        }

        public void TurnOffAllPins()
        {
            foreach (var pin in AvailablePins)
                TurnOffPin(pin);
        }

        public void TurnOnAllPins()
        {
            foreach (var pin in AvailablePins)
                TurnOnPin(pin);
        }

        public void ReportCapabilities()
        {
            BoardCapability cap = session.GetBoardCapability();
            form.UpdateStatusListBox("Board Capability:");

            foreach (var pin in cap.Pins)
            {
                form.UpdateStatusListBox($"Pin {pin.PinNumber}: Input: {pin.DigitalInput}, Output: {pin.DigitalOutput}, Analog: {pin.Analog}, Analog-Res: {pin.AnalogResolution}, PWM: {pin.Pwm}, PWM-Res: {pin.PwmResolution}, Servo: {pin.Servo}, Servo-Res: {pin.ServoResolution}, Serial: {pin.Serial}, Encoder: {pin.Encoder}, Input-pullup: {pin.InputPullup}");
                AvailablePins.Add(pin.PinNumber);
            }

            form.allActionsTabControl.SelectedTab = form.statusPage;
        }

        private void Session_OnAnalogStateReceived(object sender, FirmataEventArgs<AnalogState> eventArgs)
        {
            if (eventArgs.Value.Channel == Properties.Settings.Default.channelTemperatureSensor)
            {
                if (previousTemperatureLevel != eventArgs.Value.Level)
                {
                    this.form.UpdateStatusListBoxAsync(form, eventArgs);
                    previousTemperatureLevel = eventArgs.Value.Level;
                }
            }
            else if (eventArgs.Value.Channel == Properties.Settings.Default.waterCounterPin)
            {
                if (previousWaterSensorLockLevel <= 300 && eventArgs.Value.Level > 300)
                {
                    previousWaterSensorLockLevel = eventArgs.Value.Level;
                }
                else if (previousWaterSensorLockLevel > 300 && eventArgs.Value.Level <= 300)
                {
                    previousWaterSensorLockLevel = eventArgs.Value.Level;
                    form.UpdateClicksAsync(form, eventArgs);
                }
                else
                {
                    previousWaterSensorLockLevel = eventArgs.Value.Level;
                }
            }
        }

        public void ListenTemperature()
        {
            firmata.AnalogStateReceived += Session_OnAnalogStateReceived;
            firmata.ResetBoard();
            firmata.SetAnalogReportMode(Properties.Settings.Default.channelTemperatureSensor, true);
            firmata.SetAnalogReportMode(3, true);
            firmata.SetSamplingInterval(Properties.Settings.Default.howOftenToCheckSensors); // todo: edit this parameter
        }

        public void Disconnect()
        {
            try
            {
                if (connection != null)
                {
                    firmata.ResetBoard();
                    connection.Close();
                }
            }
            catch
            {
                // nothing
            }
        }
    }
}
