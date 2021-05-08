using EFCoreLearningDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreLearningDemo.Data
{
    public class DbInitializer
    {
        public static void Initialize(LearningDbContext context)
        {
            if (context.Depts.Any())
            {
                return;
            }
            var depts = new Dept[]
            {
                new Dept{Id=101, Name="Accounting", Loc="Dallas"},
                new Dept{Id=102, Name="Marketting", Loc="Chicago"},
                new Dept{Id=103, Name="Sales", Loc="Boston"}
            };
            context.Depts.AddRange(depts);
            context.SaveChanges();
        }
    }
}
