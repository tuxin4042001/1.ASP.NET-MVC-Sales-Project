namespace ntpstone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAvailableQuantityinQuartzDomainModel : DbMigration
    {
        public override void Up()
        {
            Sql("Update Quartzs Set AvailableQuantity = StockQuantity");
        }
        
        public override void Down()
        {

        }
    }
}
