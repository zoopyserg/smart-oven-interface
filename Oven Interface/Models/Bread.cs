using Oven_Interface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oven_Interface
{
    public class Bread
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<TemperaturePoint> TemperaturePoints { get; set; }

        public List<PressurePoint> PressurePoints { get; set; }

        public List<ValvePoint> ValvePoints { get; set; }

        public int Duration { get; set; }

        public string DisplayString
        {
            get { return $"{ Name } (Тривалість: {(Duration/60)}хв)"; }
        }

        public long CurrentExpectedTemperature(int minute)
        {
            long temp = 0;
            List<TemperaturePoint> sortedTempPoints = this.TemperaturePoints;
            if (sortedTempPoints.Count > 0)
            {
                sortedTempPoints = sortedTempPoints.Where(temperaturePoint => temperaturePoint.Minute <= minute).ToList();
                if (sortedTempPoints.Count > 0)
                {
                    sortedTempPoints.Sort((a, b) => b.Minute.CompareTo(a.Minute));
                    TemperaturePoint lastPoint = sortedTempPoints.First();
                    temp = lastPoint.Value;
                } else
                {
                    temp = 0;
                }
            }
            else
            {
                temp = 0;
            }

            return temp;

        }


    }
}
