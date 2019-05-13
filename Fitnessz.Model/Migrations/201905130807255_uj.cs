namespace Fitnessz.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class uj : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Berlets", "Inaktiv", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Berlets", "Inaktiv");
        }
    }
}
