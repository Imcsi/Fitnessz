namespace Fitnessz.Model
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class KliensMoldelDB : DbContext
    {
        // Your context has been configured to use a 'KliensMoldelDB' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Fitnessz.Model.KliensMoldelDB' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'KliensMoldelDB' 
        // connection string in the application configuration file.
        public KliensMoldelDB()
            : base("name=KliensMoldelDB")
        {
        }

        public DbSet<Belepesek> Belepesek { get; set; }
        public DbSet<Berlet> Berlet{ get; set; }
        public DbSet<Kliens> Kliens { get; set; }
        public DbSet<KliensBerlet> KliensBerlet { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}