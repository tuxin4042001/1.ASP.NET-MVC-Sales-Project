namespace ntpstone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addConsumptionAmountAndDiscountRate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "ConsumptionAmount", c => c.Double(nullable: false));
            AddColumn("dbo.MembershipTypes", "DiscountRate2", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "DiscountRate2");
            DropColumn("dbo.Customers", "ConsumptionAmount");
        }
    }
}
