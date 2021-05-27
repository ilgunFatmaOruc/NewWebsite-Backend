namespace NewsWebSite.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                        CategoryDescription = c.String(),
                        IsActivated = c.Boolean(nullable: false),
                        CreatedTime = c.DateTime(),
                        OnModifiedTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Item",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NewsTitle = c.String(),
                        NewsSubTitle = c.String(),
                        NewsContent = c.String(),
                        IsPublishing = c.Boolean(nullable: false),
                        NewsImage = c.String(),
                        CategoryId = c.Int(nullable: false),
                        IsActivated = c.Boolean(nullable: false),
                        CreatedTime = c.DateTime(),
                        OnModifiedTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Category", t => t.CategoryId)
                .Index(t => t.CategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Item", "CategoryId", "dbo.Category");
            DropIndex("dbo.Item", new[] { "CategoryId" });
            DropTable("dbo.Item");
            DropTable("dbo.Category");
        }
    }
}
