namespace NAiME.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removedRedundantSavingThrow : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Characters", "CharacterSavingThrows_SavingThrowStrength");
            DropColumn("dbo.Characters", "CharacterSavingThrows_SavingThrowDexterity");
            DropColumn("dbo.Characters", "CharacterSavingThrows_SavingThrowConstitution");
            DropColumn("dbo.Characters", "CharacterSavingThrows_SavingThrowIntelligence");
            DropColumn("dbo.Characters", "CharacterSavingThrows_SavingThrowWisdom");
            DropColumn("dbo.Characters", "CharacterSavingThrows_SavingThrowCharisma");
            DropColumn("dbo.Characters", "CharacterSavingThrows_SavingThrowCorruption");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Characters", "CharacterSavingThrows_SavingThrowCorruption", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "CharacterSavingThrows_SavingThrowCharisma", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "CharacterSavingThrows_SavingThrowWisdom", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "CharacterSavingThrows_SavingThrowIntelligence", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "CharacterSavingThrows_SavingThrowConstitution", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "CharacterSavingThrows_SavingThrowDexterity", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "CharacterSavingThrows_SavingThrowStrength", c => c.Boolean(nullable: false));
        }
    }
}
