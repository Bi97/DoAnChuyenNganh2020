namespace WebApplication13.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcolumn2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DonHangs", "TrangThaiDH", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.DonHangs", "TrangThaiDH", c => c.Int(nullable: false));
        }
    }
}
