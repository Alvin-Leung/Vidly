namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'327dafeb-eb4a-4bb1-98dc-503510b95f53', N'admin@vidly.com', 0, N'APMguFinCIt2zF7jUteRNgpC90RGp/T+frhcwapSMv8zGbljaYpKc4sQ/BbMsWypaA==', N'8ade0f4b-f066-416e-8f16-9c860fc5af71', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'71c773dd-bff8-4bb8-8fff-d52c5de092e6', N'guest@vidly.com', 0, N'AHQ1pAdAlGu3T/To6pZHA1MrhzyrquX2ohq0n5gtJfjYnX3aRrg01sWS18T6BDpyJg==', N'ced6e488-368b-4a91-a1f1-a03eeb0412d5', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'84e7de06-bb4e-4453-a0ec-7aa8b8e75aa1', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'327dafeb-eb4a-4bb1-98dc-503510b95f53', N'84e7de06-bb4e-4453-a0ec-7aa8b8e75aa1')
");
        }
        
        public override void Down()
        {
        }
    }
}
