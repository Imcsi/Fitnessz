namespace Fitnessz.Model.DBContext
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class FitnesszModelDB : DbContext
    {
        // Your context has been configured to use a 'FitnesszModelDB' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Fitnessz.Model.DBContext.FitnesszModelDB' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'FitnesszModelDB' 
        // connection string in the application configuration file.
        public FitnesszModelDB()
            : base("FitnesszModelDB")
        {
        }

        public virtual DbSet<Belepes> Belepesek { get; set; }
        public virtual DbSet<Berlet> Berletek { get; set; }
        public virtual DbSet<Kliens> Kliensek { get; set; }
        public virtual DbSet<KliensBerlet> KliensBerletek { get; set; }

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