namespace NAiME.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLastLoginToAspNetUsersTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "LastLogin", c => c.DateTime(nullable: false));
            CreateIndex("dbo.AspNetUsers", "UserToken");
        }
        
        public override void Down()
        {
            DropIndex("dbo.AspNetUsers", new[] { "UserToken" });
            DropColumn("dbo.AspNetUsers", "LastLogin");
        }
    }
}
