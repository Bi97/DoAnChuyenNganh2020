namespace WebApplication13.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcolumn3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DonHangs", "TokenKey", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.DonHangs", "TokenKey");
        }
    }
}
