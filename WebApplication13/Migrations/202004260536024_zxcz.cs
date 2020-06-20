namespace WebApplication13.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class zxcz : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DonHangs", "TongTien", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.DonHangs", "TongTien", c => c.Single(nullable: false));
        }
    }
}
