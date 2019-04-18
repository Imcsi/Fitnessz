namespace Fitnessz.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fitnesszurl : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Kliens", "SzuletesiDatum", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Kliens", "SzuletesiDatum", c => c.DateTime(nullable: false));
        }
    }
}
