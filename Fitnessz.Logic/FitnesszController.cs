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


        public  void KliensekMentese(Kliens kliens)
        {
            fitnesszDatabase.Kliensek.Add(kliens);
             fitnesszDatabase.SaveChanges();
        }

        public void KliensAdatTorles(Kliens kliens)
        {
            var item = fitnesszDatabase.Kliensek.FirstOrDefault(k => k.KliensId == kliens.KliensId && k.Inaktiv==false);

            if (item != null)
            {
                item.Inaktiv = true;

                fitnesszDatabase.SaveChanges();

            }
        }

        public  void KliensAdatModositas(Kliens kliens)
        {
            var item =   fitnesszDatabase.Kliensek.FirstOrDefault(k => k.KliensId == kliens.KliensId);

            if(item != null)
            {
                item.Nev = kliens.Nev;
                item.SzuletesiDatum = kliens.SzuletesiDatum;
                item.TelSzam = kliens.TelSzam;
                item.VonalKod = kliens.VonalKod;
                item.Nem = kliens.Nem;

                fitnesszDatabase.SaveChanges();

            }
        }

        public  List<Kliens> KeresKliens(string nev)
        {
            return  fitnesszDatabase.Kliensek.Where(p => p.Nev.Contains(nev) && p.Inaktiv==false).ToList();
           

        }

        public void BerletAdatTorles(Berlet berlet)
        {
            var item = fitnesszDatabase.Berletek.FirstOrDefault(k => k.BerletId == berlet.BerletId );

            if (item != null)
            {
                
                fitnesszDatabase.SaveChanges();

            }
        }

        public List<Berlet> KeresBerlet(int id)
        {
            return fitnesszDatabase.Berletek.Where(p => p.BerletId==id).ToList();


        }

        public void BerletAdatModositas(Berlet berlet)
        {
            var item = fitnesszDatabase.Berletek.FirstOrDefault(k => k.BerletId == berlet.BerletId);

            if (item != null)
            {
                item.NapokSzama = berlet.NapokSzama;
                item.KezdetiNap = berlet.KezdetiNap;
                item.BelepesekSzama = berlet.BelepesekSzama;
                item.Ar = berlet.Ar;
                item.Hanytol = berlet.Hanytol;
                item.Hanyig = berlet.Hanyig;
                fitnesszDatabase.SaveChanges();

            }
        }

        public void BerletekMentese(Berlet berlet)
        {
            fitnesszDatabase.Berletek.Add(berlet);
            fitnesszDatabase.SaveChanges();
        }

    }
}
