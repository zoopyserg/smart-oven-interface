using System;
using Xunit;
using OvenInterface;
using Oven_Interface.Models;

namespace OvenInterface.Specs
{
    public class PressurePointTests
    {
        [Fact]
        public void DisplayString_ShowsFullInfo()
        {
            Oven_Interface.Models.PressurePoint point = new Oven_Interface.Models.PressurePoint();
            point.Minute = 123;
            point.Value = 34;

            Assert.Equal("На 123й хвилині виставити тиск води 34 Па", point.DisplayString);
        }
    }
}
