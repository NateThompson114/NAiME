namespace NAiME.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedAllRemainingItemsForCharacterSheet : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Characters", "ArmourClass", c => c.Int(nullable: false));
            AddColumn("dbo.Characters", "Speed", c => c.Int(nullable: false));
            AddColumn("dbo.Characters", "HitPointsCurrent", c => c.Int(nullable: false));
            AddColumn("dbo.Characters", "HitPointsMaximum", c => c.Int(nullable: false));
            AddColumn("dbo.Characters", "HitPointsTemporary", c => c.Int(nullable: false));
            AddColumn("dbo.Characters", "Miserable", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "CharacterWeapon1_Name", c => c.String(maxLength: 20));
            AddColumn("dbo.Characters", "CharacterWeapon1_AttackBonus", c => c.String(maxLength: 6));
            AddColumn("dbo.Characters", "CharacterWeapon1_DamageType", c => c.String(maxLength: 60));
            AddColumn("dbo.Characters", "CharacterWeapon2_Name", c => c.String(maxLength: 20));
            AddColumn("dbo.Characters", "CharacterWeapon2_AttackBonus", c => c.String(maxLength: 6));
            AddColumn("dbo.Characters", "CharacterWeapon2_DamageType", c => c.String(maxLength: 60));
            AddColumn("dbo.Characters", "CharacterWeapon3_Name", c => c.String(maxLength: 20));
            AddColumn("dbo.Characters", "CharacterWeapon3_AttackBonus", c => c.String(maxLength: 6));
            AddColumn("dbo.Characters", "CharacterWeapon3_DamageType", c => c.String(maxLength: 60));
            AddColumn("dbo.Characters", "Gold", c => c.Int(nullable: false));
            AddColumn("dbo.Characters", "Silver", c => c.Int(nullable: false));
            AddColumn("dbo.Characters", "Copper", c => c.Int(nullable: false));
            AddColumn("dbo.Characters", "Equipment", c => c.String(maxLength: 200));
            AddColumn("dbo.Characters", "OtherProficienciesAndLangages", c => c.String(maxLength: 200));
            AddColumn("dbo.Characters", "StandardOfLiving", c => c.String(maxLength: 40));
            AddColumn("dbo.Characters", "CharacterBasics_Age", c => c.Int(nullable: false));
            AddColumn("dbo.Characters", "CharacterBasics_Height", c => c.String(maxLength: 10));
            AddColumn("dbo.Characters", "CharacterBasics_Weight", c => c.Int(nullable: false));
            AddColumn("dbo.Characters", "CharacterBasics_Eyes", c => c.String(maxLength: 10));
            AddColumn("dbo.Characters", "CharacterBasics_Skin", c => c.String(maxLength: 10));
            AddColumn("dbo.Characters", "CharacterBasics_Hair", c => c.String(maxLength: 10));
            AddColumn("dbo.Characters", "CharacterAppearance", c => c.String(maxLength: 500));
            AddColumn("dbo.Characters", "AlliesAndPatrons", c => c.String(maxLength: 500));
            AddColumn("dbo.Characters", "CharacterBackstory", c => c.String(maxLength: 500));
            AddColumn("dbo.Characters", "AdditionalFeaturesAndTraits", c => c.String(maxLength: 500));
            AddColumn("dbo.Characters", "Treasure", c => c.String(maxLength: 500));
            DropColumn("dbo.Characters", "ExperiencePoints");
            DropTable("dbo.CharacterWeapons");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.CharacterWeapons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CharacterId = c.Int(nullable: false),
                        Name = c.String(maxLength: 20),
                        AttackBonus = c.String(maxLength: 6),
                        DamageType = c.String(maxLength: 60),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Characters", "ExperiencePoints", c => c.Int(nullable: false));
            DropColumn("dbo.Characters", "Treasure");
            DropColumn("dbo.Characters", "AdditionalFeaturesAndTraits");
            DropColumn("dbo.Characters", "CharacterBackstory");
            DropColumn("dbo.Characters", "AlliesAndPatrons");
            DropColumn("dbo.Characters", "CharacterAppearance");
            DropColumn("dbo.Characters", "CharacterBasics_Hair");
            DropColumn("dbo.Characters", "CharacterBasics_Skin");
            DropColumn("dbo.Characters", "CharacterBasics_Eyes");
            DropColumn("dbo.Characters", "CharacterBasics_Weight");
            DropColumn("dbo.Characters", "CharacterBasics_Height");
            DropColumn("dbo.Characters", "CharacterBasics_Age");
            DropColumn("dbo.Characters", "StandardOfLiving");
            DropColumn("dbo.Characters", "OtherProficienciesAndLangages");
            DropColumn("dbo.Characters", "Equipment");
            DropColumn("dbo.Characters", "Copper");
            DropColumn("dbo.Characters", "Silver");
            DropColumn("dbo.Characters", "Gold");
            DropColumn("dbo.Characters", "CharacterWeapon3_DamageType");
            DropColumn("dbo.Characters", "CharacterWeapon3_AttackBonus");
            DropColumn("dbo.Characters", "CharacterWeapon3_Name");
            DropColumn("dbo.Characters", "CharacterWeapon2_DamageType");
            DropColumn("dbo.Characters", "CharacterWeapon2_AttackBonus");
            DropColumn("dbo.Characters", "CharacterWeapon2_Name");
            DropColumn("dbo.Characters", "CharacterWeapon1_DamageType");
            DropColumn("dbo.Characters", "CharacterWeapon1_AttackBonus");
            DropColumn("dbo.Characters", "CharacterWeapon1_Name");
            DropColumn("dbo.Characters", "Miserable");
            DropColumn("dbo.Characters", "HitPointsTemporary");
            DropColumn("dbo.Characters", "HitPointsMaximum");
            DropColumn("dbo.Characters", "HitPointsCurrent");
            DropColumn("dbo.Characters", "Speed");
            DropColumn("dbo.Characters", "ArmourClass");
        }
    }
}
