using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oven_Interface.Models
{
    public class ValvePoint
    {
        public int Id { get; set; }

        public int Minute { get; set; }
        
        public int Value { get; set; }

        public int BreadId { get; set; }
    }
}
