using Fitnessz.Model;
using Fitnessz.Model.DBContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitnessz.Logic
{

    public class FitnesszController
    {
        private FitnesszModelDB fitnesszDatabase;

        public FitnesszController()
        {
             this.fitnesszDatabase = new FitnesszModelDB();
            // this.fitnesszDatabase.Belepesek.Add(new Model.Belepesek { BelepesekId = 1, Datum = new DateTime(), KliensBerletId = 2 });
           
        }

        public void GetBelepesek()
        {
            var x = fitnesszDatabase.Kliensek.ToList();
                // Create and save a new Kliens
                //Console.Write("Enter a name for a new Kliens: ");
                //var name = Console.ReadLine();

                //var kliens = new Kliens { KliensId=1,Nev=name} ;
                //db.Kliensek.Add(kliens);
               // db.SaveChanges();

                // Display all Klines from the database
                var query = from b in fitnesszDatabase.Kliensek
                            orderby b.Nev
                            select b;

                //Console.WriteLine("All kliens in the database:");
            

               
            
        }
    }
}
