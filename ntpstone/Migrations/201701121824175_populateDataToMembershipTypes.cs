namespace ntpstone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateDataToMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Id, SignFee, DurationInMonths, DiscountRate, Name) VALUES (1,0,0,0,'Dayly Subscriber')");
            Sql("INSERT INTO MembershipTypes (Id, SignFee, DurationInMonths, DiscountRate, Name) VALUES (2,30,1,10,'Monthly Subscriber')");
            Sql("INSERT INTO MembershipTypes (Id, SignFee, DurationInMonths, DiscountRate, Name) VALUES (3,90,3,15, 'Seasonly Subscriber')");
            Sql("INSERT INTO MembershipTypes (Id, SignFee, DurationInMonths, DiscountRate, Name) VALUES (4,300,12,20, 'Yearly Subscriber')");
        }
        
        public override void Down()
        {
        }
    }
}
