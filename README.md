# Smart Oven Interface
Interface to turn a simple heating element into a smart oven (with temperature curves etc).

# Download

https://github.com/zoopyserg/smart-oven-interface/raw/master/Oven%20Thermoregulator.zip


# Required Hardware

- Windows computer (any)
- Arduino UNO with Firmata Standard firmware (or any Arduino board)
- 8-pin Relay module
- DuPont connectors and Bradboard

# Interface screenshot:

![Alt text](assets/img/oven%20demo2.png?raw=true "Screenshot")

# Setup Diagram

![Alt text](assets/img/Scheme.png?raw=true "Diagram")

Connection takes 5 minutes:

- Plug the Arduino into a USB
- Connect the relay module to USB (removing the jumper)
- Apply 5V from the Arduino to the positive bus
- Apply GND from Arduino to negative bus
- Connect the Arduino pins (from 3 to 10) on the Input pins in the relay (the order is irrelevant, the setting of which relay is responsible for what will be in the interface).
- Connect 5V from the bus to the VCC on the relay module.
- Connect GND from bus to GND on relay module.

Connecting the temperature sensor (for example, 3-wire PT100, which is already in most stoves):
- GND temperature sensor to GND bus
- The first signal wire (any of the two remaining) to the Arduino analog port (any: A0-A5 - the channel will be selected in the Interface)
- Connect the second signal wire through a resistor to the 5V bus.

After that, it remains to plug in the heater selected in the Interface relay, and that's it.

The temperature sensor will supply the temperature to the interface, and the interface will maintain the desired temperature with this heater.

# The interface has the following functions:
- Create an unlimited number of Furnace modes
- Each mode can have an unlimited number of temperature points (set the desired temperature at the selected minute).
- All temperature points are summarized in one graph.
- Ability to start / stop or pause / continue the selected mode (during which the computer will close the heater relay to reach the desired temperature on the temperature sensor, when the temperature of the relay opens and the program will maintain the temperature indicated at this time). .
- The progress of the program is indicated in a clear form "what percentage is completed and how many minutes are left until the end".
- It is possible to calibrate the interface specifically for your temperature sensor and specifically your type of stove
- It is possible to choose which pin is responsible for what (to which the temperature sensor is connected, to which heater relay, etc.).
- Arduino connection test features
- And more.
