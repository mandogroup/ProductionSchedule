namespace ProductionSchedule.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Allocations",
                c => new
                    {
                        AllocationId = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Status = c.String(),
                        Hours = c.Double(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AllocationId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Allocations");
        }
    }
}
