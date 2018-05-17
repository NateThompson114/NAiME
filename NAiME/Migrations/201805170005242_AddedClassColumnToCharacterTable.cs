namespace NAiME.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedClassColumnToCharacterTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Characters", "Class", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Characters", "Class");
        }
    }
}
