namespace SharpieTwitHer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class happytimes : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Tweets", name: "ApplicationUser_Id", newName: "User_Id");
            RenameIndex(table: "dbo.Tweets", name: "IX_ApplicationUser_Id", newName: "IX_User_Id");  
            AddColumn("dbo.Tweets", "CreatedAt", c => c.DateTime(nullable: false));

          //  AddColumn("dbo.Tweets", "TweetContent", c => c.String());
            RenameColumn(table: "dbo.Tweets", name: "Body", newName: "TweetContent");
          //  DropColumn("dbo.Tweets", "Body");
        }
        
        public override void Down()
        {
        //    AddColumn("dbo.Tweets", "Body", c => c.String());
        //    DropColumn("dbo.Tweets", "TweetContent");
            RenameColumn(table: "dbo.Tweets", name:"TweetContent" , newName: "Body");

            DropColumn("dbo.Tweets", "CreatedAt");
            RenameIndex(table: "dbo.Tweets", name: "IX_User_Id", newName: "IX_ApplicationUser_Id");
            RenameColumn(table: "dbo.Tweets", name: "User_Id", newName: "ApplicationUser_Id");
        }
    }
}
