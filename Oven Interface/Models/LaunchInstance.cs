using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oven_Interface.Models
{
    public class LaunchInstance
    {
        public int Id { get; set; }
        
        public string Status { get; set; }

        public int MinutesPassed { get; set; }

        public int BreadId { get; set; }

        public DateTime CreatedAt { get; set; }

        public string DisplayString
        {
            get { return $"Запуск в {CreatedAt.ToString()}. Тривав: {(MinutesPassed / 60).ToString()}хв. Статус: {Status.ToString()}."; }
        }
    }
}
