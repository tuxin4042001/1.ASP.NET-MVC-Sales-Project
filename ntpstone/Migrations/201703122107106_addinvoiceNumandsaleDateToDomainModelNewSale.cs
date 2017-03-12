namespace ntpstone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addinvoiceNumandsaleDateToDomainModelNewSale : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NewSales", "invoiceNum", c => c.String(nullable: false));
            AddColumn("dbo.NewSales", "saleDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.NewSales", "saleDate");
            DropColumn("dbo.NewSales", "invoiceNum");
        }
    }
}
