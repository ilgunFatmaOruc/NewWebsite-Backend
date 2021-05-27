namespace NewsWebSite.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThirdMig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        EmailAddress = c.String(),
                        PhoneNumber = c.String(),
                        BirthDateTime = c.DateTime(),
                        UserName = c.String(),
                        UserPassword = c.String(),
                        IsActivated = c.Boolean(nullable: false),
                        CreatedTime = c.DateTime(),
                        OnModifiedTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.User");
        }
    }
}
