namespace Fitnessz.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mi : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.KliensBerlets", "KliensId");
          //  AddForeignKey("dbo.KliensBerlets", "KliensId", "dbo.Kliens", "KliensId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.KliensBerlets", "KliensId", "dbo.Kliens");
            DropIndex("dbo.KliensBerlets", new[] { "KliensId" });
        }
    }
}
