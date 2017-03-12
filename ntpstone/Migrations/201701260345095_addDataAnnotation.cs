namespace ntpstone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDataAnnotation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 225));
            AlterColumn("dbo.Customers", "Address", c => c.String(nullable: false, maxLength: 225));
            AlterColumn("dbo.Customers", "ZipCode", c => c.String(nullable: false, maxLength: 225));
            AlterColumn("dbo.Customers", "CellPhoneNumber", c => c.String(nullable: false, maxLength: 225));
            AlterColumn("dbo.Customers", "City", c => c.String(nullable: false, maxLength: 225));
            AlterColumn("dbo.Customers", "District", c => c.String(nullable: false, maxLength: 225));
            AlterColumn("dbo.Customers", "ContactPerson", c => c.String(nullable: false, maxLength: 225));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "ContactPerson", c => c.String());
            AlterColumn("dbo.Customers", "District", c => c.String());
            AlterColumn("dbo.Customers", "City", c => c.String());
            AlterColumn("dbo.Customers", "CellPhoneNumber", c => c.String());
            AlterColumn("dbo.Customers", "ZipCode", c => c.String());
            AlterColumn("dbo.Customers", "Address", c => c.String());
            AlterColumn("dbo.Customers", "Name", c => c.String());
        }
    }
}
