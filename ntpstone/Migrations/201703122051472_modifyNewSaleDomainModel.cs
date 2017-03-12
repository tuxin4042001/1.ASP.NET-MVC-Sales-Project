namespace ntpstone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifyNewSaleDomainModel : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.NewSales", "invoiceNum");
            DropColumn("dbo.NewSales", "saleDate");
            DropColumn("dbo.NewSales", "saleQuantity");
            DropColumn("dbo.NewSales", "unitPrice");
            DropColumn("dbo.NewSales", "salePrice");
            DropColumn("dbo.NewSales", "GST");
            DropColumn("dbo.NewSales", "lineTotal");
            DropColumn("dbo.NewSales", "paymentMethod");
            DropColumn("dbo.NewSales", "shortCredit");
            DropColumn("dbo.NewSales", "overCredit");
            DropColumn("dbo.NewSales", "paymentInfo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.NewSales", "paymentInfo", c => c.String());
            AddColumn("dbo.NewSales", "overCredit", c => c.Double(nullable: false));
            AddColumn("dbo.NewSales", "shortCredit", c => c.Double(nullable: false));
            AddColumn("dbo.NewSales", "paymentMethod", c => c.String());
            AddColumn("dbo.NewSales", "lineTotal", c => c.Double(nullable: false));
            AddColumn("dbo.NewSales", "GST", c => c.Double(nullable: false));
            AddColumn("dbo.NewSales", "salePrice", c => c.Double(nullable: false));
            AddColumn("dbo.NewSales", "unitPrice", c => c.Double(nullable: false));
            AddColumn("dbo.NewSales", "saleQuantity", c => c.Int(nullable: false));
            AddColumn("dbo.NewSales", "saleDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.NewSales", "invoiceNum", c => c.String());
        }
    }
}
