using System;
using Xunit;
using OvenInterface;
using Oven_Interface.Models;

namespace OvenInterface.Specs
{
    public class LaunchInstanceTests
    {
        [Fact]
        public void DisplayString_ShowsFullInfo()
        {
            LaunchInstance instance = new LaunchInstance();
            DateTime time = new DateTime();
            time = DateTime.Now;
            
            instance.CreatedAt = time;
            instance.MinutesPassed = 123;
            instance.Status = "started";

            Assert.Equal($"Запуск в {time.ToString()}. Тривав: 123хв. Статус: started.", instance.DisplayString);
        }
    }
}
