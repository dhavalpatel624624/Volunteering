namespace Volunteering.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Enrollment",
                c => new
                    {
                        EnrollmentID = c.Int(nullable: false, identity: true),
                        EventID = c.Int(nullable: false),
                        VolunteerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EnrollmentID)
                .ForeignKey("dbo.Event", t => t.EventID, cascadeDelete: true)
                .ForeignKey("dbo.Volunteer", t => t.VolunteerID, cascadeDelete: true)
                .Index(t => t.EventID)
                .Index(t => t.VolunteerID);
            
            CreateTable(
                "dbo.Event",
                c => new
                    {
                        EventID = c.Int(nullable: false),
                        Title = c.String(),
                        Description = c.String(),
                        Location = c.String(),
                        EventLength = c.String(),
                        EventDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.EventID);
            
            CreateTable(
                "dbo.Volunteer",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LastName = c.String(),
                        FirstMidName = c.String(),
                        Gender = c.String(),
                        Age = c.Int(nullable: false),
                        EnrollmentDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enrollment", "VolunteerID", "dbo.Volunteer");
            DropForeignKey("dbo.Enrollment", "EventID", "dbo.Event");
            DropIndex("dbo.Enrollment", new[] { "VolunteerID" });
            DropIndex("dbo.Enrollment", new[] { "EventID" });
            DropTable("dbo.Volunteer");
            DropTable("dbo.Event");
            DropTable("dbo.Enrollment");
        }
    }
}
