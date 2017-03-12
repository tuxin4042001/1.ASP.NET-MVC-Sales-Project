namespace ntpstone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateDataToConsumptionAmountAndDiscountRate2 : DbMigration
    {
        public override void Up()
        {
            Sql("delete from Customers where Id = 9");
            Sql("delete from Customers where Id = 10");
            Sql("delete from Customers where Id = 11");
            Sql("delete from Customers where Id = 12");
            Sql("delete from Customers where Id = 13");
            Sql("delete from Customers where Id = 14");
            Sql("delete from Customers where Id = 15");
            Sql("delete from Customers where Id = 16");
            Sql("delete from Customers where Id = 18");
            Sql("update MembershipTypes set DiscountRate = 5 where Id = 2");
            Sql("update MembershipTypes set DiscountRate = 7 where Id = 3");
            Sql("update MembershipTypes set DiscountRate = 10 where Id = 4");
            Sql("update MembershipTypes set Name = 'Normal' where Id = 1");
            Sql("update MembershipTypes set Name = 'Intermediate' where Id = 2");
            Sql("update MembershipTypes set Name = 'Senior' where Id = 3");
            Sql("update MembershipTypes set Name = 'Advanced' where Id = 4");
            Sql("update MembershipTypes set DiscountRate2 = 0 where Id = 1");
            Sql("update MembershipTypes set DiscountRate2 = 0.05 where Id = 2");
            Sql("update MembershipTypes set DiscountRate2 = 0.07 where Id = 3");
            Sql("update MembershipTypes set DiscountRate2 = 0.1 where Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
