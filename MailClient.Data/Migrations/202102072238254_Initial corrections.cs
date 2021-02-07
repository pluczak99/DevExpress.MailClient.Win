namespace MailClient.Data.Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialcorrections : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ToDoTask",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AllDay = c.Boolean(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Note = c.String(nullable: false),
                        Location = c.String(nullable: false),
                        RecurrenceInfo = c.String(),
                        ReminderInfo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ToDoTaskUser",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ToDoTaskUser");
            DropTable("dbo.ToDoTask");
        }
    }
}
