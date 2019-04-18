namespace Fitnessz.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Belepes",
                c => new
                    {
                        BelepesekId = c.Int(nullable: false, identity: true),
                        Datum = c.DateTime(nullable: false),
                        KliensBerletId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BelepesekId);
            
            CreateTable(
                "dbo.Berlets",
                c => new
                    {
                        BerletId = c.Int(nullable: false, identity: true),
                        Tipus = c.String(),
                        Ar = c.Int(nullable: false),
                        NapokSzama = c.Int(nullable: false),
                        NapontaHanyszor = c.Int(nullable: false),
                        BelepesekSzama = c.Int(nullable: false),
                        Hanytol = c.Int(nullable: false),
                        Hanyig = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BerletId);
            
            CreateTable(
                "dbo.KliensBerlets",
                c => new
                    {
                        KliensBerletId = c.Int(nullable: false, identity: true),
                        VonalKod = c.String(),
                        BerletId = c.Int(nullable: false),
                        NapokSzama = c.Int(nullable: false),
                        KezdetiNap = c.DateTime(nullable: false),
                        BelepesekSzama = c.Int(nullable: false),
                        EladasiAr = c.Int(nullable: false),
                        Ervenyesseg = c.Boolean(nullable: false),
                        Belepesek_BelepesekId = c.Int(),
                        Kliens_KliensId = c.Int(),
                    })
                .PrimaryKey(t => t.KliensBerletId)
                .ForeignKey("dbo.Belepes", t => t.Belepesek_BelepesekId)
                .ForeignKey("dbo.Berlets", t => t.BerletId, cascadeDelete: true)
                .ForeignKey("dbo.Kliens", t => t.Kliens_KliensId)
                .Index(t => t.BerletId)
                .Index(t => t.Belepesek_BelepesekId)
                .Index(t => t.Kliens_KliensId);
            
            CreateTable(
                "dbo.Kliens",
                c => new
                    {
                        KliensId = c.Int(nullable: false, identity: true),
                        Nev = c.String(),
                        SzuletesiDatum = c.DateTime(nullable: false),
                        TelSzam = c.String(),
                        VonalKod = c.String(),
                        Nem = c.String(),
                    })
                .PrimaryKey(t => t.KliensId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.KliensBerlets", "Kliens_KliensId", "dbo.Kliens");
            DropForeignKey("dbo.KliensBerlets", "BerletId", "dbo.Berlets");
            DropForeignKey("dbo.KliensBerlets", "Belepesek_BelepesekId", "dbo.Belepes");
            DropIndex("dbo.KliensBerlets", new[] { "Kliens_KliensId" });
            DropIndex("dbo.KliensBerlets", new[] { "Belepesek_BelepesekId" });
            DropIndex("dbo.KliensBerlets", new[] { "BerletId" });
            DropTable("dbo.Kliens");
            DropTable("dbo.KliensBerlets");
            DropTable("dbo.Berlets");
            DropTable("dbo.Belepes");
        }
    }
}
