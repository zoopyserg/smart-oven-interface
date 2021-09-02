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
            get { return $"{ Name } (Тривалість: {Duration}хв)"; }
        }


    }
}
