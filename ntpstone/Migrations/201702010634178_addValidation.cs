namespace ntpstone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addValidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "WebSite", c => c.String(maxLength: 255));
            AlterColumn("dbo.Customers", "Email", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Email", c => c.String());
            AlterColumn("dbo.Customers", "WebSite", c => c.String());
        }
    }
}
