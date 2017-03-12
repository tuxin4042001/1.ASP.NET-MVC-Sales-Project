namespace ntpstone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateDataToQuartzs : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Quartzs (Name, ModelNumber, thickness, ArrivalQuantity, SaleQuantity, StockQuantity, ActualStockQuantity, Color) Values ('1201','1201','3cm','104','77','27','26','TCE 2011')");
            Sql("insert into Quartzs (Name, ModelNumber, thickness, ArrivalQuantity, SaleQuantity, StockQuantity, ActualStockQuantity, Color) Values ('1203','1203','3cm','156','153','3','3','TCE 2013')");
            Sql("insert into Quartzs (Name, ModelNumber, thickness, ArrivalQuantity, SaleQuantity, StockQuantity, ActualStockQuantity, Color) Values ('1205','1205','3cm','106','103','3','3','TCE 2013')");
            Sql("insert into Quartzs (Name, ModelNumber, thickness, ArrivalQuantity, SaleQuantity, StockQuantity, ActualStockQuantity, Color) Values ('1206','1206','3cm','80','35','45','44','TCE 502')");

        }

        public override void Down()
        {
        }
    }
}
