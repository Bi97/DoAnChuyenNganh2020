namespace WebApplication13.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcolumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DonHangs", "TrangThaiDH", c => c.Int(nullable: false));
            AddColumn("dbo.KhachHangs", "EmailKH", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.KhachHangs", "EmailKH");
            DropColumn("dbo.DonHangs", "TrangThaiDH");
        }
    }
}
