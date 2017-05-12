namespace Crawler.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addColParentID : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CrawlerSubLink", "ParentID", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CrawlerSubLink", "ParentID");
        }
    }
}
