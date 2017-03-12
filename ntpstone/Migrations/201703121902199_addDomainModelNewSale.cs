namespace ntpstone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDomainModelNewSale : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NewSales",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        invoiceNum = c.String(nullable: false),
                        saleDate = c.DateTime(nullable: false),
                        saleQuantity = c.Int(nullable: false),
                        unitPrice = c.Double(nullable: false),
                        salePrice = c.Double(nullable: false),
                        GST = c.Double(nullable: false),
                        lineTotal = c.Double(nullable: false),
                        paymentMethod = c.String(nullable: false),
                        shortCredit = c.Double(nullable: false),
                        overCredit = c.Double(nullable: false),
                        paymentInfo = c.String(),
                        Customer_Id = c.Int(nullable: false),
                        Quartz_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id, cascadeDelete: true)
                .ForeignKey("dbo.Quartzs", t => t.Quartz_Id, cascadeDelete: true)
                .Index(t => t.Customer_Id)
                .Index(t => t.Quartz_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NewSales", "Quartz_Id", "dbo.Quartzs");
            DropForeignKey("dbo.NewSales", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.NewSales", new[] { "Quartz_Id" });
            DropIndex("dbo.NewSales", new[] { "Customer_Id" });
            DropTable("dbo.NewSales");
        }
    }
}
