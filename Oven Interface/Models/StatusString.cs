using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oven_Interface.Models
{
    public class StatusLine
    {
        public string Name { get; set; }

        public DateTime CreatedAt { get; set; }

        public string DisplayString
        {
            get { return $"[{CreatedAt.ToString()}]: { Name }"; }
        }
    }
}
