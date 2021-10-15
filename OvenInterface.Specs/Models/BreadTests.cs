using System;
using Xunit;
using OvenInterface;
using Oven_Interface.Models;
using System.Collections.Generic;

namespace OvenInterface.Specs
{
    public class BreadTests
    {
        [Fact]
        public void DisplayString_ShowsFullInfo()
        {
            Oven_Interface.Bread bread = new Oven_Interface.Bread();
            bread.Name = "Borodynskyi";
            bread.Duration = 123;

            Assert.Equal("Borodynskyi (Тривалість: 123хв)", bread.DisplayString);
        }

        [Fact]
        public void CurrentExpectedTemperature_GetsTemperatureOfLastTempPoint()
        {
            Oven_Interface.Bread bread = new Oven_Interface.Bread();

            bread.TemperaturePoints = new List<TemperaturePoint>();
            TemperaturePoint tp1 = new TemperaturePoint();
            tp1.Minute = 1;
            tp1.Value = 2;

            TemperaturePoint tp2 = new TemperaturePoint();
            tp2.Minute = 5;
            tp2.Value = 10;

            TemperaturePoint tp3 = new TemperaturePoint();
            tp3.Minute = 10;
            tp3.Value = 100;

            bread.TemperaturePoints.Add(tp1);
            bread.TemperaturePoints.Add(tp2);
            bread.TemperaturePoints.Add(tp3);

            Assert.Equal(2, bread.CurrentExpectedTemperature(1));
            Assert.Equal(2, bread.CurrentExpectedTemperature(3));
            Assert.Equal(10, bread.CurrentExpectedTemperature(5));
            Assert.Equal(10, bread.CurrentExpectedTemperature(6));
            Assert.Equal(10, bread.CurrentExpectedTemperature(8));
            Assert.Equal(100, bread.CurrentExpectedTemperature(10));
            Assert.Equal(100, bread.CurrentExpectedTemperature(11));
            Assert.Equal(100, bread.CurrentExpectedTemperature(500));
        }
    }
}
