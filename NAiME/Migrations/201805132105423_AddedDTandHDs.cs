namespace NAiME.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDTandHDs : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Characters", "CharacterHitPoints_HitPointsCurrent", c => c.Int(nullable: false));
            AddColumn("dbo.Characters", "CharacterHitPoints_HitPointsMaximum", c => c.Int(nullable: false));
            AddColumn("dbo.Characters", "CharacterHitPoints_HitPointsTemporary", c => c.Int(nullable: false));
            AddColumn("dbo.Characters", "Background", c => c.String(maxLength: 20));
            AddColumn("dbo.Characters", "PlayerName", c => c.String(maxLength: 60));
            AddColumn("dbo.Characters", "Culture", c => c.String(maxLength: 20));
            AddColumn("dbo.Characters", "ShadowWeakness", c => c.String(maxLength: 20));
            AddColumn("dbo.Characters", "CharacterHitDices_HitDice", c => c.String(maxLength: 6));
            AddColumn("dbo.Characters", "CharacterHitDices_Total", c => c.Int(nullable: false));
            AddColumn("dbo.Characters", "CharacterDeathThrows_Succes", c => c.Int(nullable: false));
            AddColumn("dbo.Characters", "CharacterDeathThrows_Failure", c => c.Int(nullable: false));
            DropColumn("dbo.Characters", "HitPointsCurrent");
            DropColumn("dbo.Characters", "HitPointsMaximum");
            DropColumn("dbo.Characters", "HitPointsTemporary");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Characters", "HitPointsTemporary", c => c.Int(nullable: false));
            AddColumn("dbo.Characters", "HitPointsMaximum", c => c.Int(nullable: false));
            AddColumn("dbo.Characters", "HitPointsCurrent", c => c.Int(nullable: false));
            DropColumn("dbo.Characters", "CharacterDeathThrows_Failure");
            DropColumn("dbo.Characters", "CharacterDeathThrows_Succes");
            DropColumn("dbo.Characters", "CharacterHitDices_Total");
            DropColumn("dbo.Characters", "CharacterHitDices_HitDice");
            DropColumn("dbo.Characters", "ShadowWeakness");
            DropColumn("dbo.Characters", "Culture");
            DropColumn("dbo.Characters", "PlayerName");
            DropColumn("dbo.Characters", "Background");
            DropColumn("dbo.Characters", "CharacterHitPoints_HitPointsTemporary");
            DropColumn("dbo.Characters", "CharacterHitPoints_HitPointsMaximum");
            DropColumn("dbo.Characters", "CharacterHitPoints_HitPointsCurrent");
        }
    }
}
