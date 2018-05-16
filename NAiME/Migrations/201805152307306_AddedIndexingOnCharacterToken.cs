namespace NAiME.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedIndexingOnCharacterToken : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Characters", "CharacterToken");
            CreateIndex("dbo.Characters", "PlayerToken");
            CreateIndex("dbo.Characters", "GroupToken");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Characters", new[] { "GroupToken" });
            DropIndex("dbo.Characters", new[] { "PlayerToken" });
            DropIndex("dbo.Characters", new[] { "CharacterToken" });
        }
    }
}
