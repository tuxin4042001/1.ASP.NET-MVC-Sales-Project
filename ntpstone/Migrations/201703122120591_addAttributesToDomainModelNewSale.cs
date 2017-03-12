namespace ntpstone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAttributesToDomainModelNewSale : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NewSales", "saleQuantity", c => c.Int(nullable: false));
            AddColumn("dbo.NewSales", "unitPrice", c => c.Double(nullable: false));
            AddColumn("dbo.NewSales", "salePrice", c => c.Double(nullable: false));
            AddColumn("dbo.NewSales", "GST", c => c.Double(nullable: false));
            AddColumn("dbo.NewSales", "lineTotal", c => c.Double(nullable: false));
            AddColumn("dbo.NewSales", "paymentMethod", c => c.String());
            AddColumn("dbo.NewSales", "shortCredit", c => c.Double(nullable: false));
            AddColumn("dbo.NewSales", "overCredit", c => c.Double(nullable: false));
            AddColumn("dbo.NewSales", "paymentInfo", c => c.String());
            AlterColumn("dbo.NewSales", "invoiceNum", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.NewSales", "invoiceNum", c => c.String(nullable: false));
            DropColumn("dbo.NewSales", "paymentInfo");
            DropColumn("dbo.NewSales", "overCredit");
            DropColumn("dbo.NewSales", "shortCredit");
            DropColumn("dbo.NewSales", "paymentMethod");
            DropColumn("dbo.NewSales", "lineTotal");
            DropColumn("dbo.NewSales", "GST");
            DropColumn("dbo.NewSales", "salePrice");
            DropColumn("dbo.NewSales", "unitPrice");
            DropColumn("dbo.NewSales", "saleQuantity");
        }
    }
}
