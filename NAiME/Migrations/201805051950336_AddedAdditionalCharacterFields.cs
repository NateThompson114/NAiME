namespace NAiME.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAdditionalCharacterFields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Characters", "ExperiencePoints", c => c.Int(nullable: false));
            AddColumn("dbo.Characters", "CharacterMainStats_Strength", c => c.Int(nullable: false));
            AddColumn("dbo.Characters", "CharacterMainStats_Dexterity", c => c.Int(nullable: false));
            AddColumn("dbo.Characters", "CharacterMainStats_Constitution", c => c.Int(nullable: false));
            AddColumn("dbo.Characters", "CharacterMainStats_Intelligence", c => c.Int(nullable: false));
            AddColumn("dbo.Characters", "CharacterMainStats_Wisdom", c => c.Int(nullable: false));
            AddColumn("dbo.Characters", "CharacterMainStats_Charisma", c => c.Int(nullable: false));
            AddColumn("dbo.Characters", "CharacterMainStats_Shadow", c => c.Int(nullable: false));
            AddColumn("dbo.Characters", "CharacterSavingThrows_SavingThrowStrength", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "CharacterSavingThrows_SavingThrowStrengthMultiplier", c => c.Int(nullable: false));
            AddColumn("dbo.Characters", "CharacterSavingThrows_SavingThrowDexterity", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "CharacterSavingThrows_SavingThrowDexterityMultiplier", c => c.Int(nullable: false));
            AddColumn("dbo.Characters", "CharacterSavingThrows_SavingThrowConstitution", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "CharacterSavingThrows_SavingThrowConstitutionMultiplier", c => c.Int(nullable: false));
            AddColumn("dbo.Characters", "CharacterSavingThrows_SavingThrowIntelligence", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "CharacterSavingThrows_SavingThrowIntelligenceMultiplier", c => c.Int(nullable: false));
            AddColumn("dbo.Characters", "CharacterSavingThrows_SavingThrowWisdom", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "CharacterSavingThrows_SavingThrowWisdomMultiplier", c => c.Int(nullable: false));
            AddColumn("dbo.Characters", "CharacterSavingThrows_SavingThrowCharisma", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "CharacterSavingThrows_SavingThrowCharismaMultiplier", c => c.Int(nullable: false));
            AddColumn("dbo.Characters", "CharacterSavingThrows_SavingThrowCorruption", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "CharacterSavingThrows_SavingThrowCorruptionMultiplier", c => c.Int(nullable: false));
            AddColumn("dbo.Characters", "CharacterSkills_AcrobaticsDex", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "CharacterSkills_AnimalHandlingWis", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "CharacterSkills_AthleticsStr", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "CharacterSkills_DeceptionCha", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "CharacterSkills_HistoryInt", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "CharacterSkills_InsightWis", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "CharacterSkills_IntimidationCha", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "CharacterSkills_InvestigationInt", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "CharacterSkills_LoreInt", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "CharacterSkills_MedicineWis", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "CharacterSkills_NatureInt", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "CharacterSkills_PerceptionWis", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "CharacterSkills_PerformanceCha", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "CharacterSkills_PersuasionCha", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "CharacterSkills_RiddleInt", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "CharacterSkills_ShadowLoreInt", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "CharacterSkills_SleightOfHandDex", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "CharacterSkills_StealthDex", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "CharacterSkills_SurvivalWis", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "CharacterSkills_TraditionsInt", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "CharacterLevel_Level", c => c.Int(nullable: false));
            AddColumn("dbo.Characters", "CharacterLevel_ExperiencePoints", c => c.Int(nullable: false));
            DropColumn("dbo.Characters", "Strength");
            DropColumn("dbo.Characters", "Dexterity");
            DropColumn("dbo.Characters", "Constitution");
            DropColumn("dbo.Characters", "Intelligence");
            DropColumn("dbo.Characters", "Wisdom");
            DropColumn("dbo.Characters", "Charisma");
            DropColumn("dbo.Characters", "Shadow");
            DropColumn("dbo.Characters", "PermanentShadow");
            DropColumn("dbo.Characters", "ProficiencyBonus");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Characters", "ProficiencyBonus", c => c.Int(nullable: false));
            AddColumn("dbo.Characters", "PermanentShadow", c => c.Int(nullable: false));
            AddColumn("dbo.Characters", "Shadow", c => c.Int(nullable: false));
            AddColumn("dbo.Characters", "Charisma", c => c.Int(nullable: false));
            AddColumn("dbo.Characters", "Wisdom", c => c.Int(nullable: false));
            AddColumn("dbo.Characters", "Intelligence", c => c.Int(nullable: false));
            AddColumn("dbo.Characters", "Constitution", c => c.Int(nullable: false));
            AddColumn("dbo.Characters", "Dexterity", c => c.Int(nullable: false));
            AddColumn("dbo.Characters", "Strength", c => c.Int(nullable: false));
            DropColumn("dbo.Characters", "CharacterLevel_ExperiencePoints");
            DropColumn("dbo.Characters", "CharacterLevel_Level");
            DropColumn("dbo.Characters", "CharacterSkills_TraditionsInt");
            DropColumn("dbo.Characters", "CharacterSkills_SurvivalWis");
            DropColumn("dbo.Characters", "CharacterSkills_StealthDex");
            DropColumn("dbo.Characters", "CharacterSkills_SleightOfHandDex");
            DropColumn("dbo.Characters", "CharacterSkills_ShadowLoreInt");
            DropColumn("dbo.Characters", "CharacterSkills_RiddleInt");
            DropColumn("dbo.Characters", "CharacterSkills_PersuasionCha");
            DropColumn("dbo.Characters", "CharacterSkills_PerformanceCha");
            DropColumn("dbo.Characters", "CharacterSkills_PerceptionWis");
            DropColumn("dbo.Characters", "CharacterSkills_NatureInt");
            DropColumn("dbo.Characters", "CharacterSkills_MedicineWis");
            DropColumn("dbo.Characters", "CharacterSkills_LoreInt");
            DropColumn("dbo.Characters", "CharacterSkills_InvestigationInt");
            DropColumn("dbo.Characters", "CharacterSkills_IntimidationCha");
            DropColumn("dbo.Characters", "CharacterSkills_InsightWis");
            DropColumn("dbo.Characters", "CharacterSkills_HistoryInt");
            DropColumn("dbo.Characters", "CharacterSkills_DeceptionCha");
            DropColumn("dbo.Characters", "CharacterSkills_AthleticsStr");
            DropColumn("dbo.Characters", "CharacterSkills_AnimalHandlingWis");
            DropColumn("dbo.Characters", "CharacterSkills_AcrobaticsDex");
            DropColumn("dbo.Characters", "CharacterSavingThrows_SavingThrowCorruptionMultiplier");
            DropColumn("dbo.Characters", "CharacterSavingThrows_SavingThrowCorruption");
            DropColumn("dbo.Characters", "CharacterSavingThrows_SavingThrowCharismaMultiplier");
            DropColumn("dbo.Characters", "CharacterSavingThrows_SavingThrowCharisma");
            DropColumn("dbo.Characters", "CharacterSavingThrows_SavingThrowWisdomMultiplier");
            DropColumn("dbo.Characters", "CharacterSavingThrows_SavingThrowWisdom");
            DropColumn("dbo.Characters", "CharacterSavingThrows_SavingThrowIntelligenceMultiplier");
            DropColumn("dbo.Characters", "CharacterSavingThrows_SavingThrowIntelligence");
            DropColumn("dbo.Characters", "CharacterSavingThrows_SavingThrowConstitutionMultiplier");
            DropColumn("dbo.Characters", "CharacterSavingThrows_SavingThrowConstitution");
            DropColumn("dbo.Characters", "CharacterSavingThrows_SavingThrowDexterityMultiplier");
            DropColumn("dbo.Characters", "CharacterSavingThrows_SavingThrowDexterity");
            DropColumn("dbo.Characters", "CharacterSavingThrows_SavingThrowStrengthMultiplier");
            DropColumn("dbo.Characters", "CharacterSavingThrows_SavingThrowStrength");
            DropColumn("dbo.Characters", "CharacterMainStats_Shadow");
            DropColumn("dbo.Characters", "CharacterMainStats_Charisma");
            DropColumn("dbo.Characters", "CharacterMainStats_Wisdom");
            DropColumn("dbo.Characters", "CharacterMainStats_Intelligence");
            DropColumn("dbo.Characters", "CharacterMainStats_Constitution");
            DropColumn("dbo.Characters", "CharacterMainStats_Dexterity");
            DropColumn("dbo.Characters", "CharacterMainStats_Strength");
            DropColumn("dbo.Characters", "ExperiencePoints");
        }
    }
}
