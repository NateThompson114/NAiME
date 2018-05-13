namespace NAiME.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingAttacksAndFeatures : DbMigration
    {
        public override void Up()
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
            
            AddColumn("dbo.Characters", "Attacks", c => c.String(maxLength: 200));
            AddColumn("dbo.Characters", "FeaturesTraitsVirtues", c => c.String(maxLength: 1000));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Characters", "FeaturesTraitsVirtues");
            DropColumn("dbo.Characters", "Attacks");
            DropTable("dbo.CharacterWeapons");
        }
    }
}
