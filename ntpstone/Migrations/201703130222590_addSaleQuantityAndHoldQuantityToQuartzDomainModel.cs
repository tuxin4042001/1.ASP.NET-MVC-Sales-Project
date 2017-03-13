namespace ntpstone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addSaleQuantityAndHoldQuantityToQuartzDomainModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Quartzs", "SaleQuantity2", c => c.Int(nullable: false));
            AddColumn("dbo.Quartzs", "HoldQuantity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Quartzs", "HoldQuantity");
            DropColumn("dbo.Quartzs", "SaleQuantity2");
        }
    }
}
