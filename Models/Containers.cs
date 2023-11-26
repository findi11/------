using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Курсач.Models
{
    public class Containers
    {
        public int ID { get; set; }
        public string container { get; set; }
        public int PersonId { get; set; }
        public DateTime DataStart { get; set; }
        public DateTime DataEnd { get; set; }
        public int currentProgres { get; set; }
        public int endProgres { get; set; }



    }
}
