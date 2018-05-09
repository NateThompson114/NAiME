namespace NAiME.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class expandedVersionNumberOnChangeLog : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ChangeLogs", "VersionNumber", c => c.String(nullable: false, maxLength: 40));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ChangeLogs", "VersionNumber", c => c.String(nullable: false, maxLength: 10));
        }
    }
}
