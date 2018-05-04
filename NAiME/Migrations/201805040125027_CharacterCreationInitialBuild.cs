namespace NAiME.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CharacterCreationInitialBuild : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Characters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        CharacterToken = c.String(maxLength: 200),
                        PlayerToken = c.String(maxLength: 200),
                        GroupToken = c.String(maxLength: 200),
                        Strength = c.Int(nullable: false),
                        Dexterity = c.Int(nullable: false),
                        Constitution = c.Int(nullable: false),
                        Intelligence = c.Int(nullable: false),
                        Wisdom = c.Int(nullable: false),
                        Charisma = c.Int(nullable: false),
                        Shadow = c.Int(nullable: false),
                        PermanentShadow = c.Int(nullable: false),
                        ProficiencyBonus = c.Int(nullable: false),
                        Inspiration = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AlterColumn("dbo.AspNetUsers", "UserToken", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "UserToken", c => c.String(maxLength: 1000));
            DropTable("dbo.Characters");
        }
    }
}
