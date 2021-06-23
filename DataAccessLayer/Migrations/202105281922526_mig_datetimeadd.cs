namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_datetimeadd : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Headings", "HeadingDate", c => c.DateTime(nullable: true, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Headings", "HeadingDate", c => c.DateTime(nullable: true));
        }
    }
}
