namespace Crawler.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addColLinkHTML : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PostNews", "LinkHTML", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PostNews", "LinkHTML");
        }
    }
}
