namespace NAiME.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedProficiencyToCharacterLevel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Characters", "CharacterLevel_ProficiencyBonus", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Characters", "CharacterLevel_ProficiencyBonus");
        }
    }
}
