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
        public void KliensBerleteMentese(KliensBerlet kliensBerlet)
        {
            fitnesszDatabase.KliensBerletek.Add(kliensBerlet);
            fitnesszDatabase.SaveChanges();
        }

        public void BerletTipusMentese(Berlet berlet)
        {
            fitnesszDatabase.Berletek.Add(berlet);
            fitnesszDatabase.SaveChanges();
        }

        public List<KliensBerlet> KeresBerlet(string keresettBerlet)
        {
            throw new NotImplementedException();
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

        public void BerletTipusAdatTorles(Berlet berlet)
        {
            var item = fitnesszDatabase.Berletek.FirstOrDefault(k => k.BerletId == berlet.BerletId && k.Inaktiv == false);

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

        public void BelepesSzamNoveles(KliensBerlet berlet,int novel)
        {
            var item = fitnesszDatabase.KliensBerletek.Find(berlet.KliensBerletId);
            //string iDate = "05/05/2005";
            DateTime oDate = Convert.ToDateTime(berlet.KezdetiNap);
            var lejarasiIdo = oDate.AddDays(berlet.NapokSzama);
            if (lejarasiIdo.Date < DateTime.Now.Date)
            {
                
                item.BelepesekSzama = item.BelepesekSzama + novel;

                fitnesszDatabase.SaveChangesAsync();
            }


        }

        public void IdotartamNoveles(KliensBerlet berlet, DateTime novel)
        {
            
            var item = fitnesszDatabase.KliensBerletek.Find(berlet.KliensBerletId);
            DateTime oDate = Convert.ToDateTime(berlet.KezdetiNap); // az adatbazisban levo stringet datumma alakitja
            var lejarasiIdo = oDate.AddDays(berlet.NapokSzama);
            var hozzaadottErtek = novel - lejarasiIdo;
            if (lejarasiIdo.Date < DateTime.Now.Date)
            {

                item.NapokSzama = item.NapokSzama + hozzaadottErtek.Days;

                fitnesszDatabase.SaveChangesAsync();
            }


        }

        

        public void BerletTipusAdatModositas(Berlet berlet)
        {
            var item = fitnesszDatabase.Berletek.FirstOrDefault(k => k.BerletId == berlet.BerletId);

            if (item != null)
            {
                item.Tipus = berlet.Tipus;
                item.Ar = berlet.Ar;
                item.BelepesekSzama = berlet.BelepesekSzama;
                item.Hanyig = berlet.Hanyig;
                item.Hanytol = berlet.Hanytol;
                item.NapokSzama = berlet.NapokSzama;
                item.NapontaHanyszor = berlet.NapontaHanyszor;
                

                fitnesszDatabase.SaveChanges();

            }
        }

        public  List<Kliens> KeresKliens(string nev)
        {
            return  fitnesszDatabase.Kliensek.Where(p => p.Nev.Contains(nev) && p.Inaktiv==false).ToList();
           

        }

        public List<Berlet> KeresBerletTipus(string tipus)
        {
            return fitnesszDatabase.Berletek.Where(p => p.Tipus.Contains(tipus) && p.Inaktiv == false).ToList();


        }

        public List<KliensBerlet> KeresesBerlet(string keresesiszo)
        {
            return fitnesszDatabase.KliensBerletek.Where(p => p.VonalKod.Contains(keresesiszo) || (from e in fitnesszDatabase.Kliensek
                                                                                               where e.Nev.Contains(keresesiszo)
                                                                                                  select e.KliensId).Contains(p.KliensId)).ToList();
        }

    }
}
