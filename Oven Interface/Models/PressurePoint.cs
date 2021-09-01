using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oven_Interface.Models
{
    class PressurePoint
    {
        public int Id { get; }

        public int Minute { get; set; }
        
        public int Value { get; set; }

        public int BreadId { get; set; }
    }
}
