using Fitnessz.Common.FitnesszContentTypes;
using Fitnessz.Common.MVVM;
using Fitnessz.Logic;
using Fitnessz.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitnessz.ViewModel.UserControls
{
    
   public class KliensViewModel:ViewModelBase,INotifyPropertyChanged, IKliensContent
    {
        public static FitnesszController fitnesszController;

        public KliensViewModel()
        {
            this.CloseCommand = new RelayCommand(this.CloseCommandExecute);
            this.HozzaadKliensCommand = new RelayCommand(this.HozzaadKliensCommandExecute);
            this.KeresesKliensCommand = new RelayCommand(this.KeresesKliensCommandExecute);
            this.KeresettAdatMegjelenites = new RelayCommand(this.KeresettAdatMegjelenitesExecute);
            this.ModositasKliensCommand = new RelayCommand(this.ModositasKliensCommandExecute);
            this.TorlesKliensCommand = new RelayCommand(this.TorlesKliensCommandExecute);
        }

        private void TorlesKliensCommandExecute()
        {
            Data.fitnesszController.KliensAdatTorles(KivalasztottKliens);
            KeresesKliensCommandExecute();
            TorolTextBoxElemek();
        }

        private void ModositasKliensCommandExecute()
        {
            Data.fitnesszController.KliensAdatModositas(new Kliens
            {
                TelSzam = KliensTelSzam,
                KliensId = kivalasztottKliens.KliensId,
                Nev = KliensNeve,
                SzuletesiDatum = KliensSzuletesiDatum,
                VonalKod = KliensVonalKod,
                Nem = KliensNeme
            });
            KeresesKliensCommandExecute();
            TorolTextBoxElemek();
        }

        private void TorolTextBoxElemek()
        {
            KliensNeve = "";
            KliensNeme = "";
            KliensSzuletesiDatum = "";
            KliensTelSzam = "";
            KliensVonalKod = "";

        }

        private void KeresettAdatMegjelenitesExecute()
        {

            KliensNeve = KivalasztottKliens.Nev;
            KliensSzuletesiDatum = KivalasztottKliens.SzuletesiDatum;
            KliensTelSzam = KivalasztottKliens.TelSzam;
            KliensVonalKod = KivalasztottKliens.VonalKod;
            KliensNeme = KivalasztottKliens.Nem;


        }

        private Kliens kivalasztottKliens;

        public Kliens KivalasztottKliens
        {
            get { return kivalasztottKliens; }
            set
            {
                kivalasztottKliens = value;
                RaisePropertyChanged();
            }
        }


        private void KeresesKliensCommandExecute()
        {
            KliensLista = Data.fitnesszController.KeresKliens(KeresettKliens);
        }

        private List<Kliens> kliensLista;

        public List<Kliens> KliensLista
        {
            get { return kliensLista; }
            set
            {
                kliensLista = value;
                RaisePropertyChanged();

            }
        }



        private string kliensNeve;

        public string KliensNeve
        {
            get { return kliensNeve; }
            set
            {
                kliensNeve = value;
                this.RaisePropertyChanged();
            }
        }

        private string kliensSzuletesiDatum;

        public string KliensSzuletesiDatum
        {
            get { return kliensSzuletesiDatum; }
            set
            {
                kliensSzuletesiDatum = value;
                this.RaisePropertyChanged();
            }
        }

        private string kliensNeme;

        public string KliensNeme
        {
            get { return kliensNeme; }
            set
            {
                kliensNeme = value;
                this.RaisePropertyChanged();
            }
        }

        private string kliensTelSzam;

        public string KliensTelSzam
        {
            get { return kliensTelSzam; }
            set
            {
                kliensTelSzam = value;
                this.RaisePropertyChanged();
            }
        }

        private string kliensVonalKod;

        public string KliensVonalKod
        {
            get { return kliensVonalKod; }
            set
            {
                kliensVonalKod = value;
                this.RaisePropertyChanged();
            }
        }

        private string keresettKliens;

        public string KeresettKliens
        {
            get { return keresettKliens; }
            set
            {
                keresettKliens = value;
                this.RaisePropertyChanged();
            }
        }




        private void HozzaadKliensCommandExecute()
        {
            Data.fitnesszController.KliensekMentese(new Kliens
            {
                Nev = KliensNeve,
                SzuletesiDatum = KliensSzuletesiDatum,
                Nem = KliensNeme,
                TelSzam = KliensTelSzam,
                VonalKod = KliensVonalKod


            });

            TorolTextBoxElemek();
        }





        public RelayCommand CloseCommand { get; set; }

        public RelayCommand HozzaadKliensCommand { get; set; }
        public RelayCommand KeresesKliensCommand { get; set; }
        public RelayCommand KeresettAdatMegjelenites { get; set; }
        public RelayCommand ModositasKliensCommand { get; private set; }
        public RelayCommand TorlesKliensCommand { get; set; }

        public string Header => "Kliensek";

        public void CloseCommandExecute()
        {
            ViewService.CloseDialog(this);
        }



    }
}

