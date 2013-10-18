using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using ProductionSchedule.Models;

namespace ProductionSchedule.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ProductionSchedule.Models.ProductionScheduleContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ProductionSchedule.Models.ProductionScheduleContext context)
        {
            context.Allocations.AddOrUpdate(p => p.AllocationId,
               new Allocation
               {
                   Title = "Home page template",
                   Date = DateTime.Now,
                   Hours = 3,
                   Status = "Requested",
               },
               new Allocation
               {
                   Title = "Landing page template",
                   Date = DateTime.Now,
                   Hours = 2,
                   Status = "Requested",
               }
                );
        }
    }
}
