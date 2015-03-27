namespace SharpieTwitHer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Added_Tweet_Limit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tweets", "UserId", c => c.String());
            AddColumn("dbo.Tweets", "TweetContent", c => c.String());
            AddColumn("dbo.Tweets", "CreatedAt", c => c.DateTime(nullable: false));
            DropColumn("dbo.Tweets", "Body");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tweets", "Body", c => c.String());
            DropColumn("dbo.Tweets", "CreatedAt");
            DropColumn("dbo.Tweets", "TweetContent");
            DropColumn("dbo.Tweets", "UserId");
        }
    }
}
