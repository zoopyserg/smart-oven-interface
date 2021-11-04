using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oven_Interface.Models
{
    public class PressurePoint
    {
        public int Id { get; set; }

        public int Minute { get; set; }
        
        public decimal Value { get; set; }

        public int BreadId { get; set; }
        public string DisplayString
        {
            get { return $"На {(Minute/60).ToString()}й хвилині залити {Value.ToString()} л води"; }
        }
    }
}
