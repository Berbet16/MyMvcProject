namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class object_error : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Headings", "HeadingStatus", c => c.Boolean(nullable: false));
            AddColumn("dbo.Contents", "ContentStatus", c => c.Boolean(nullable: false));
            AddColumn("dbo.Writers", "WriterStatus", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Writers", "WriterStatus");
            DropColumn("dbo.Contents", "ContentStatus");
            DropColumn("dbo.Headings", "HeadingStatus");
        }
    }
}
