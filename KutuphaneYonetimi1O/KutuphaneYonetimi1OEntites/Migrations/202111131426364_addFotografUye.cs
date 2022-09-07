namespace KutuphaneYonetimi1OEntites.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addFotografUye : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblUye", "Fotograf", c => c.String(maxLength: 250, unicode: false));
            AlterColumn("dbo.tblUye", "Telefon", c => c.String(maxLength: 15, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tblUye", "Telefon", c => c.String(maxLength: 15, fixedLength: true, unicode: false));
            DropColumn("dbo.tblUye", "Fotograf");
        }
    }
}
