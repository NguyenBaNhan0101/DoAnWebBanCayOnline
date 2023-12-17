namespace DoAnWebBanCayOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class insert_username_in_order : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Order", "UserName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_Order", "UserName");
        }
    }
}
