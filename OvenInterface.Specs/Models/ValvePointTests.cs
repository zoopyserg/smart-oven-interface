using System;
using Xunit;
using OvenInterface;
using Oven_Interface.Models;

namespace OvenInterface.Specs
{
    public class ValvePointTests
    {
        [Fact]
        public void DisplayString_ShowsFullInfo()
        {
            Oven_Interface.Models.ValvePoint point = new Oven_Interface.Models.ValvePoint();
            point.Minute = 123;
            point.Value = 34;

            Assert.Equal("На 123й хвилині відкрити клапан пари на 34 відсотків", point.DisplayString);
        }
    }
}
