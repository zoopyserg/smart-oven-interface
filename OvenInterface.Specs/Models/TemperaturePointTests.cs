using System;
using Xunit;
using OvenInterface;
using Oven_Interface.Models;

namespace OvenInterface.Specs
{
    public class TemperaturePointTests
    {
        [Fact]
        public void DisplayString_ShowsFullInfo()
        {
            Oven_Interface.Models.TemperaturePoint point = new Oven_Interface.Models.TemperaturePoint();
            point.Minute = 123;
            point.Value = 34;

            Assert.Equal("На 123й хвилині виставити 34 градусів", point.DisplayString);
        }
    }
}
