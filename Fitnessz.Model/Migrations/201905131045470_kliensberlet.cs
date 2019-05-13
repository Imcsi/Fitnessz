namespace Fitnessz.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kliensberlet : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.KliensBerlets", "Belepesek_BelepesekId", "dbo.Belepes");
            DropForeignKey("dbo.KliensBerlets", "BerletId", "dbo.Berlets");
            DropForeignKey("dbo.KliensBerlets", "Kliens_KliensId", "dbo.Kliens");
            DropIndex("dbo.KliensBerlets", new[] { "BerletId" });
            DropIndex("dbo.KliensBerlets", new[] { "Belepesek_BelepesekId" });
            DropIndex("dbo.KliensBerlets", new[] { "Kliens_KliensId" });
            AddColumn("dbo.KliensBerlets", "KliensId", c => c.Int(nullable: false));
            AddColumn("dbo.KliensBerlets", "BelepesekId", c => c.Int(nullable: false));
            DropColumn("dbo.KliensBerlets", "Belepesek_BelepesekId");
            DropColumn("dbo.KliensBerlets", "Kliens_KliensId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.KliensBerlets", "Kliens_KliensId", c => c.Int());
            AddColumn("dbo.KliensBerlets", "Belepesek_BelepesekId", c => c.Int());
            DropColumn("dbo.KliensBerlets", "BelepesekId");
            DropColumn("dbo.KliensBerlets", "KliensId");
            CreateIndex("dbo.KliensBerlets", "Kliens_KliensId");
            CreateIndex("dbo.KliensBerlets", "Belepesek_BelepesekId");
            CreateIndex("dbo.KliensBerlets", "BerletId");
            AddForeignKey("dbo.KliensBerlets", "Kliens_KliensId", "dbo.Kliens", "KliensId");
            AddForeignKey("dbo.KliensBerlets", "BerletId", "dbo.Berlets", "BerletId", cascadeDelete: true);
            AddForeignKey("dbo.KliensBerlets", "Belepesek_BelepesekId", "dbo.Belepes", "BelepesekId");
        }
    }
}
