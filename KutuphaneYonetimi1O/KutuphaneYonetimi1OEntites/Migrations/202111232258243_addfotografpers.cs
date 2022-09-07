namespace KutuphaneYonetimi1OEntites.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addfotografpers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblPersonel", "Fotograf", c => c.String(maxLength: 200, unicode: false));
            AddColumn("dbo.tblPersonel", "Telefon", c => c.String(maxLength: 15, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tblPersonel", "Telefon");
            DropColumn("dbo.tblPersonel", "Fotograf");
        }
    }
}
