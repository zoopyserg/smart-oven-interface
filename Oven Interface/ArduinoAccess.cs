using Oven_Interface.Controllers;
using Oven_Interface.Models;
using Solid.Arduino;
using Solid.Arduino.Firmata;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Oven_Interface
{
    // todo: Need to override default SerialConnection.Find method: https://github.com/SolidSoils/Arduino/blob/master/Solid.Arduino/SerialConnection.cs
    // as it finds only THE FIRST CONNECTION, and I want ALL connections.
    // or re-run Find command many times and each time exclude all the "previously found" COM ports from the list to look at. Repeat until all are found, set to a new variable each time.
    // Good idea but I don't know how to exclude COM port from the Find list.
    public class ArduinoAccess
    {
        public ISerialConnection relayBoardConnection { get; set; }
        public ISerialConnection tempSensorBoardConnection { get; set; }
        public ISerialConnection waterCounterBoardConnection { get; set; }
        
        //public ArduinoSession session { get; set; }
        public ArduinoSession relayBoardSession { get; set; }
        public ArduinoSession tempSensorBoardSession { get; set; }
        public ArduinoSession waterCounterBoardSession { get; set; }

        // public IFirmataProtocol firmata { get; set; }
        public IFirmataProtocol relayBoardFirmata { get; set; }
        public IFirmataProtocol tempSensorBoardFirmata { get; set; }
        public IFirmataProtocol waterCounterBoardFirmata { get; set; }
        
        public Dashboard form { get; set; }
        public long previousWaterSensorLockLevel { get; set; }
        public long previousTemperatureLevel { get; set; }
        public int boardNumber { get; set; }

        public List<int> AvailablePins { get; set; }

        public ArduinoAccess(Dashboard _form)
        {
            form = _form;
            AvailablePins = new List<int>();
        }

        public void Reconnect()
        {
            if (AllConnectionsPresent())
            {
                if (AllConnectionsPresent())
                {
                    ReportConnection();
                    
                    relayBoardSession.ResetBoard();
                    tempSensorBoardSession.ResetBoard();
                    waterCounterBoardSession.ResetBoard();
                    
                    ReportCapabilities(relayBoardSession);
                    ReportCapabilities(tempSensorBoardSession);
                    ReportCapabilities(waterCounterBoardSession);
                    
                    PerformInitialization();
                    ListenTemperature();
                    ListenWater();

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
                    FindAllConnections();
                    Reconnect();
                }
            }
            else
            {
                ReportNoConnection();
                Thread.Sleep(1000);
                FindAllConnections();
                Reconnect();
            }

        }

        // Find ALL devices connected to COM ports.
        public void FindAllConnections()
        {
            foreach (string port in SerialPort.GetPortNames()) // Get all COM ports
            {
                // open an EnhancedSerialConnection to that port
                var connection = new EnhancedSerialConnection(port, SerialBaudRate.Bps_57600);
                var session = new ArduinoSession(connection);
                int boardNumber = session.GetFirmware().MinorVersion;

                // if the board number is equal to relayBoardNumber in settings, it's the relay board
                if (boardNumber == Properties.Settings.Default.relayBoardNumber)
                {
                    relayBoardSession = session;
                    relayBoardConnection = connection;
                    form.UpdateStatusListBox($"Плата Номер: {boardNumber.ToString()}, Порт: {port}, плата з реле.");
                }

                // if the board number is equal to tempSensorBoardNumber in settings, it's the temp sensor board
                if (boardNumber == Properties.Settings.Default.temperatureSensorBoardNumber)
                {
                    tempSensorBoardSession = session;
                    tempSensorBoardConnection = connection;
                    form.UpdateStatusListBox($"Плата Номер: {boardNumber.ToString()}, Порт: {port}, плата з температурним сенсором.");
                }

                // if the board number is equal to waterCounterBoardNumber in settings, it's the water counter board
                if (boardNumber == Properties.Settings.Default.waterCounterBoardNumber)
                {
                    waterCounterBoardSession = session;
                    waterCounterBoardConnection = connection;
                    form.UpdateStatusListBox($"Плата Номер: {boardNumber.ToString()}, Порт: {port}, плата з лічильником води.");
                }
            }
        }

        private void ReportNoConnection()
        {
            if (AnyConnectionsBlank())
                form.UpdateStatusListBox("Немає з'єднання з контролерами Arduino. Пробую перепідключитись.");
        }

        private void ReportConnection()
        {
            if (AllConnectionsPresent())
            {
                form.UpdateStatusListBox($"Arduino контролер підключений до порта {relayBoardConnection.PortName}.");
                form.UpdateStatusListBox($"Arduino контролер підключений до порта {tempSensorBoardConnection.PortName}.");
                form.UpdateStatusListBox($"Arduino контролер підключений до порта {waterCounterBoardConnection.PortName}.");
            }
        }

        public bool AllConnectionsPresent()
        {
            return (relayBoardConnection != null && tempSensorBoardConnection != null && waterCounterBoardConnection != null);
        }
        
        public bool AnyConnectionsBlank()
        {
            return (relayBoardConnection == null || tempSensorBoardConnection == null || waterCounterBoardConnection == null);
        }

        private void PerformInitialization()
        {
            for (int i = 3; i < 14; i++) // пропускаю 1 и 2 потому что их использует USB порт.
            {
                relayBoardSession.SetDigitalPinMode(i, PinMode.DigitalOutput);
                // посылаю true потому что купил плату которая при LOW включена... пофиксить новой платой.
                relayBoardSession.SetDigitalPin(i, true);

                tempSensorBoardSession.SetDigitalPinMode(i, PinMode.DigitalOutput);
                tempSensorBoardSession.SetDigitalPin(i, true);

                waterCounterBoardSession.SetDigitalPinMode(i, PinMode.DigitalOutput);
                waterCounterBoardSession.SetDigitalPin(i, true);
            }
        }

        public void TurnOnPin(int pinNumber, int boardNumber)
        {
            if (boardNumber == Properties.Settings.Default.relayBoardNumber)
            {
                relayBoardSession.SetDigitalPin(pinNumber, false);
            }
            else if (boardNumber == Properties.Settings.Default.temperatureSensorBoardNumber)
            {
                tempSensorBoardSession.SetDigitalPin(pinNumber, false);
            }
            else if (boardNumber == Properties.Settings.Default.waterCounterBoardNumber)
            {
                waterCounterBoardSession.SetDigitalPin(pinNumber, false);
            }
            //  посылаю true потому что купил плату которая при LOW включена... пофиксить новой платой.
        }

        public void TurnOffPin(int pinNumber, int boardNumber)
        {
            if (boardNumber == Properties.Settings.Default.relayBoardNumber)
            {
                relayBoardSession.SetDigitalPin(pinNumber, true);
            }
            else if (boardNumber == Properties.Settings.Default.temperatureSensorBoardNumber)
            {
                tempSensorBoardSession.SetDigitalPin(pinNumber, true);
            }
            else if (boardNumber == Properties.Settings.Default.waterCounterBoardNumber)
            {
                waterCounterBoardSession.SetDigitalPin(pinNumber, true);
            }
            //  посылаю true потому что купил плату которая при LOW включена... пофиксить новой платой.
        }

        public void TurnOffAllPins()
        {
            foreach (var pin in AvailablePins)
            {
                TurnOffPin(pin, 1);
                TurnOffPin(pin, 2);
                TurnOffPin(pin, 3);
            }
        }

        public void TurnOnAllPins()
        {
            foreach (var pin in AvailablePins)
            {
                TurnOnPin(pin, 1);
                TurnOnPin(pin, 2);
                TurnOnPin(pin, 3);
            }
        }
        
        public void ReportCapabilities()
        {
            ReportCapabilities(relayBoardSession);
            ReportCapabilities(tempSensorBoardSession);
            ReportCapabilities(waterCounterBoardSession);
        }

        public void ReportCapabilities(ArduinoSession selectedBoard)
        {
            BoardCapability cap = selectedBoard.GetBoardCapability();

            boardNumber = selectedBoard.GetFirmware().MinorVersion;

            form.UpdateStatusListBox("Board Number: " + boardNumber.ToString());

            form.UpdateStatusListBox("Board Capability:");

            foreach (var pin in cap.Pins)
            {
                form.UpdateStatusListBox($"Pin {pin.PinNumber}: Input: {pin.DigitalInput}, Output: {pin.DigitalOutput}, Analog: {pin.Analog}, Analog-Res: {pin.AnalogResolution}, PWM: {pin.Pwm}, PWM-Res: {pin.PwmResolution}, Servo: {pin.Servo}, Servo-Res: {pin.ServoResolution}, Serial: {pin.Serial}, Encoder: {pin.Encoder}, Input-pullup: {pin.InputPullup}");
                AvailablePins.Add(pin.PinNumber);
            }

            form.allActionsTabControl.SelectedTab = form.statusPage;
        }

        private void Session_OnTemperatureAnalogStateReceived(object sender, FirmataEventArgs<AnalogState> eventArgs)
        {
            if (previousTemperatureLevel != eventArgs.Value.Level)
            {
                this.form.UpdateStatusListBoxAsync(form, eventArgs);
                previousTemperatureLevel = eventArgs.Value.Level;
            }
        }

        private void Session_OnWaterAnalogStateReceived(object sender, FirmataEventArgs<AnalogState> eventArgs)
        {
            if (previousWaterSensorLockLevel <= 300 && eventArgs.Value.Level > 300)
            {
                System.Diagnostics.Debug.WriteLine("Changing from Low to High");
                System.Diagnostics.Debug.WriteLine($"Previous Level: {previousWaterSensorLockLevel}");
                System.Diagnostics.Debug.WriteLine($"Next Level: {eventArgs.Value.Level}");
                System.Diagnostics.Debug.WriteLine($"Time: {DateTime.Now}");
                previousWaterSensorLockLevel = eventArgs.Value.Level;
                form.UpdateClicksAsync(form, eventArgs);
            }
            else if (previousWaterSensorLockLevel > 300 && eventArgs.Value.Level <= 300)
            {
                System.Diagnostics.Debug.WriteLine("Changing from High to Low");
                System.Diagnostics.Debug.WriteLine($"Previous Level: {previousWaterSensorLockLevel}");
                System.Diagnostics.Debug.WriteLine($"Next Level: {eventArgs.Value.Level}");
                System.Diagnostics.Debug.WriteLine($"Time: {DateTime.Now}");
                previousWaterSensorLockLevel = eventArgs.Value.Level;
                form.UpdateClicksAsync(form, eventArgs);
            }
        }

        public void ListenTemperature()
        {
            // todo: check if this works (it was a different class last time it did);
            tempSensorBoardSession.AnalogStateReceived += Session_OnTemperatureAnalogStateReceived;
            tempSensorBoardSession.ResetBoard();
            tempSensorBoardSession.SetAnalogReportMode(Properties.Settings.Default.channelTemperatureSensor, true);
            tempSensorBoardSession.SetSamplingInterval(Properties.Settings.Default.howOftenToCheckSensors); // todo: edit this parameter
        }

        public void ListenWater()
        {
            // todo: check if this works (it was a different class last time it did);
            waterCounterBoardSession.AnalogStateReceived += Session_OnWaterAnalogStateReceived;
            waterCounterBoardSession.ResetBoard();
            waterCounterBoardSession.SetAnalogReportMode(Properties.Settings.Default.waterCounterPin, true);
            waterCounterBoardSession.SetSamplingInterval(Properties.Settings.Default.howOftenToCheckSensors); // todo: edit this parameter
        }

        public void Disconnect()
        {
            try
            {
                if (relayBoardSession != null && tempSensorBoardSession != null && waterCounterBoardSession != null)
                {
                    relayBoardSession.ResetBoard();
                    tempSensorBoardSession.ResetBoard();
                    waterCounterBoardSession.ResetBoard();

                    relayBoardConnection.Close();
                    tempSensorBoardConnection.Close();
                    waterCounterBoardConnection.Close();
                }
            }
            catch
            {
                // nothing
            }
        }
    }
}
