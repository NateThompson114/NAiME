namespace NAiME.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedCharacterTraits : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Characters", "CharacterTraits_DistinctiveQuality", c => c.String(maxLength: 500));
            AddColumn("dbo.Characters", "CharacterTraits_Speciality", c => c.String(maxLength: 500));
            AddColumn("dbo.Characters", "CharacterTraits_Hope", c => c.String(maxLength: 500));
            AddColumn("dbo.Characters", "CharacterTraits_Despair", c => c.String(maxLength: 500));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Characters", "CharacterTraits_Despair");
            DropColumn("dbo.Characters", "CharacterTraits_Hope");
            DropColumn("dbo.Characters", "CharacterTraits_Speciality");
            DropColumn("dbo.Characters", "CharacterTraits_DistinctiveQuality");
        }
    }
}
