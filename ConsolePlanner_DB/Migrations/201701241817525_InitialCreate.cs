namespace ConsolePlanner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PlanTasks",
                c => new
                    {
                        PlanTaskID = c.Int(nullable: false, identity: true),
                        TaskName = c.String(nullable: false, maxLength: 1000),
                        TaskData = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PlanTaskID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PlanTasks");
        }
    }
}
