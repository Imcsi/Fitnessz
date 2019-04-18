using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitnessz.Model.DBContext
{
    public class DBInitializer: CreateDatabaseIfNotExists<FitnesszModelDB>
    {
        protected override void Seed(FitnesszModelDB context)
        {
            this.Belepes(context);
            this.Berlet(context);
            this.Kliens(context);
            this.KliensBerlet(context);
            
        }

        private void KliensBerlet(FitnesszModelDB context)
        {
            context.KliensBerletek.Add(new KliensBerlet { BelepesekSzama = 10, BerletId = 1, NapokSzama = 30, VonalKod = "1213459876", EladasiAr = 50, Ervenyesseg = true, KezdetiNap="2019.05.01", KliensBerletId=2});
        }

        private void Kliens(FitnesszModelDB context)
        {
            context.Kliensek.Add(new Kliens { KliensId = 2, Nem="no", Nev="Kiss Johanna", SzuletesiDatum="1997.04.23", TelSzam="0756710631", VonalKod="1213459876"});

        }

        private void Berlet(FitnesszModelDB context)
        {
            context.Berletek.Add(new Berlet {Ar=50, BelepesekSzama=10, BerletId=1, Hanyig=8, Hanytol=10, NapokSzama=30, NapontaHanyszor=1, Tipus="honapos"});
            context.Berletek.Add(new Berlet {Ar=100, BelepesekSzama=10, BerletId = 2, Hanyig = 8, Hanytol = 10, NapokSzama = 30, NapontaHanyszor = 1, Tipus = "honapos" });

        }

        private void Belepes(FitnesszModelDB context)
        {
            context.Belepesek.Add(new Belepes { BelepesekId = 1, Datum = "2019.04.12", KliensBerletId = 2 });
            context.Belepesek.Add(new Belepes { BelepesekId = 2, Datum = "2019.04.20", KliensBerletId = 2 });
        }

        
    }
}
