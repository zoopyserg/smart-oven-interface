using System;
using Xunit;
using OvenInterface;
using Oven_Interface.Models;

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
    }
}
