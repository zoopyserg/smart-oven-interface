using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oven_Interface.Models
{
    class FullBread : Bread
    {
        public int Id { get; set; }
        
        public List<TemperaturePoint> TemperaturePoints { get; set; }

        public List<PressurePoint> PressurePoints { get; set; }

        public List<ValvePoint> ValvePoints { get; set; }
    }
}
