namespace NAiME.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingChangeLog : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChangeLogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VersionNumber = c.String(nullable: false, maxLength: 10),
                        Information = c.String(nullable: false, maxLength: 300),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ChangeLogs");
        }
    }
}
