using Solid.Arduino.Firmata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oven_Interface.Controllers
{
    public static class TestPinsController
    {
        public static void TurnOnPin(Dashboard sender, IFirmataProtocol session, int pinNumber)
        {
            session.SetDigitalPinMode(pinNumber, PinMode.DigitalOutput);
            session.SetDigitalPin(pinNumber, false); //  посылаю true потому что купил плату которая при LOW включена... пофиксить новой платой.
            sender.UpdateStatusListBox($"{ pinNumber }й пін включено");
        }

        public static void TurnOffPin(Dashboard sender, IFirmataProtocol session, int pinNumber)
        {
            session.SetDigitalPinMode(pinNumber, PinMode.DigitalOutput);
            session.SetDigitalPin(pinNumber, true); //  посылаю true потому что купил плату которая при LOW включена... пофиксить новой платой.
            sender.UpdateStatusListBox($"{ pinNumber }й пін виключено");
        }
    }
}
