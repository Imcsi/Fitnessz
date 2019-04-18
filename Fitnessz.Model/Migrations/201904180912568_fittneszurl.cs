namespace Fitnessz.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fittneszurl : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Belepes", "Datum", c => c.String());
            AlterColumn("dbo.KliensBerlets", "KezdetiNap", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.KliensBerlets", "KezdetiNap", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Belepes", "Datum", c => c.DateTime(nullable: false));
        }
    }
}
