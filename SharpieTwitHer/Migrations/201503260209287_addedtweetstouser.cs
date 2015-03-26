namespace SharpieTwitHer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedtweetstouser : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tweets",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Body = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tweets", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Tweets", new[] { "ApplicationUser_Id" });
            DropTable("dbo.Tweets");
        }
    }
}
