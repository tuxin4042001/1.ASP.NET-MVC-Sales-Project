namespace ntpstone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addThreeTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        ZipCode = c.String(),
                        CellPhoneNumber = c.String(),
                        OfficeNumber = c.String(),
                        City = c.String(),
                        District = c.String(),
                        WebSite = c.String(),
                        Email = c.String(),
                        isFirstTimeBuyer = c.Boolean(nullable: false),
                        ContactPerson = c.String(),
                        MembershipTypeId = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MembershipTypes", t => t.MembershipTypeId, cascadeDelete: true)
                .Index(t => t.MembershipTypeId);
            
            CreateTable(
                "dbo.MembershipTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        SignFee = c.Short(nullable: false),
                        DurationInMonths = c.Byte(nullable: false),
                        DiscountRate = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Quartzs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ModelNumber = c.String(),
                        thickness = c.String(),
                        ArrivalQuantity = c.Int(nullable: false),
                        SaleQuantity = c.Int(nullable: false),
                        StockQuantity = c.Int(nullable: false),
                        ActualStockQuantity = c.Int(nullable: false),
                        Color = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MembershipTypeId", "dbo.MembershipTypes");
            DropIndex("dbo.Customers", new[] { "MembershipTypeId" });
            DropTable("dbo.Quartzs");
            DropTable("dbo.MembershipTypes");
            DropTable("dbo.Customers");
        }
    }
}
