namespace ntpstone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateDataToCustomer : DbMigration
    {
        public override void Up()
        {
            Sql("insert into customers(Name, Address, Zipcode, CellPhoneNumber, OfficeNumber, City, District, WebSite, Email, isFirstTimeBuyer, ContactPerson, MembershipTypeId) Values('Accurate Counter Sloutions','4736 14 St', 'T2E 6T7','4036691742','','Calgary','NE','','accuratecounter@live.ca',0,'Dan Martens',1)");
            Sql("insert into customers(Name, Address, Zipcode, CellPhoneNumber, OfficeNumber, City, District, WebSite, Email, isFirstTimeBuyer, ContactPerson, MembershipTypeId) Values('Alberta Marble  & Tile','2020 Pegasus Rd', 'T2E 8M5','4032870944','','Calgary','NE','www.albertamarble.com','giannid@albertamarble.com',0,'Gianni De Marchi',2)");
            Sql("insert into customers(Name, Address, Zipcode, CellPhoneNumber, OfficeNumber, City, District, WebSite, Email, isFirstTimeBuyer, ContactPerson, MembershipTypeId) Values('Cabinets For-U','#2148, 3961 52 Ave', 'T3J 0K7','4034579080','','Calgary','NE','www.cabinetsforu.com','info@cabinetsforu.com',0,'Mike Basi',3)");
            Sql("insert into customers(Name, Address, Zipcode, CellPhoneNumber, OfficeNumber, City, District, WebSite, Email, isFirstTimeBuyer, ContactPerson, MembershipTypeId) Values('Calgary Cabinets Depot','5421 11 St NE #108', 'T2E 6M4','4034609566','','Calgary','NE','www.calgarycabinets.com','jane@calgarycabinets.com ',0,'Jane Ly',4)");

        }

        public override void Down()
        {
        }
    }
}
