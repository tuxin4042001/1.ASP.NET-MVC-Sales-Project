namespace ntpstone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7a8a761b-4bba-4d0a-b6d9-6f2109dec15a', N'guest@ntpstone.com', 0, N'AJbis1SXr0y5LMu9HxZWLmkqyKiKwR4Jpkjp/qkYZd9tE9A+E2BGD8fVF8r31knbHg==', N'5f2cc811-968a-456d-91aa-4ddbc1e707c6', NULL, 0, 0, NULL, 1, 0, N'guest@ntpstone.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8cab8244-bc51-4eb9-9218-dbd7f4f8d841', N'admin@ntpstone.com', 0, N'AG5goDP265UXmctdlkFfhqgAmsz7Cip3QT3nsIBe1ZyHKqcDSaKC4bD7BTwqSspQ+Q==', N'9f132f49-cf77-4b83-b2f0-602804aa5c2c', NULL, 0, 0, NULL, 1, 0, N'admin@ntpstone.com')
");
            Sql(@"
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'78abf83d-8976-431a-b4b8-4853b14c24b7', N'CanManageQuartzs')
");
            Sql(@"
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8cab8244-bc51-4eb9-9218-dbd7f4f8d841', N'78abf83d-8976-431a-b4b8-4853b14c24b7')
");
        }
        
        public override void Down()
        {
        }
    }
}
