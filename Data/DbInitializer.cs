using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Курсач.Models;

namespace Курсач.Data
{
    public class DbInitializer
    {
        public static void Initialize(HumContext context)
        {
            context.Database.EnsureCreated();
          
            if (context.Container.Any())
            {
                return;  
            }

            var container = new Containers[]
            {
            new Containers{container="Речі",PersonId=111,DataStart=DateTime.Parse("2005-09-01"),DataEnd=DateTime.Parse("2022-09-01"),currentProgres = 0, endProgres = 1000},
            };
            foreach (Containers s in container)
            {
                context.Container.Add(s);
            }
            context.SaveChanges();
        }
    }
}
