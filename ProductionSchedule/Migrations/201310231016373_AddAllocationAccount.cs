namespace ProductionSchedule.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAllocationAccount : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Allocations", "Account", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Allocations", "Account");
        }
    }
}
