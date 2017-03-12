namespace ntpstone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifyNewSaleDomailModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.NewSales", "invoiceNum", c => c.String());
            AlterColumn("dbo.NewSales", "paymentMethod", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.NewSales", "paymentMethod", c => c.String(nullable: false));
            AlterColumn("dbo.NewSales", "invoiceNum", c => c.String(nullable: false));
        }
    }
}
