using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Курсач.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public List<NonActiveContainers> Containers { get; set; }
    }
}
