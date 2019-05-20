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
    public class BelepesekKoveteseViewModel : ViewModelBase, INotifyPropertyChanged, IBelepesekKoveteseContent
    {
        public static FitnesszController fitnesszController;
        public BelepesekKoveteseViewModel()
        {
            this.CloseCommand = new RelayCommand(this.CloseCommandExecute);
            this.KeresesKliensCommand = new RelayCommand(this.KeresesKliensCommandExecute);
            this.KeresettAdatMegjelenites = new RelayCommand(this.KeresettAdatMegjelenitesExecute);
            this.BelepesKliensCommand = new RelayCommand(this.BelepesKliensCommandExecute);
            Elerheto = true;
        }

        private void BelepesKliensCommandExecute()
        {
            
            if (Data.fitnesszController.ErvenyesBerlet(KivalasztottKliens) == true)
            {
                KeresettAdatMegjelenitesExecute();
            }
            else
            {
                Elerheto = false;
            }
        }

        private void KeresettAdatMegjelenitesExecute()
        {
            KliensNev = KivalasztottKliens.Kliens.Nev.ToString();
            KliensSzulDatum = KivalasztottKliens.Kliens.SzuletesiDatum.ToString();
            KliensTelSzam = KivalasztottKliens.Kliens.TelSzam.ToString();
            KliensNem = KivalasztottKliens.Kliens.Nem.ToString();
            BerletNapokSzama = KivalasztottKliens.NapokSzama.ToString();
            BerletKezdetiNap = KivalasztottKliens.KezdetiNap.ToString();
            BerletBelepesekSzama = KivalasztottKliens.BelepesekSzama.ToString();
            BerletEladasiAr = KivalasztottKliens.EladasiAr.ToString();
            BerletErvenyesseg = KivalasztottKliens.Ervenyesseg;
           
        }


        private void KeresesKliensCommandExecute()
        {
            KliensAdatok = Data.fitnesszController.KeresesKliens(KeresettKliens);
        }

        private bool elerheto;

        public bool Elerheto
        {
            get { return elerheto; }
            set { elerheto = value;
                RaisePropertyChanged();
            }
        }


        private string kliensNem;

        public string KliensNem
        {
            get { return kliensNem; }
            set
            {
                kliensNem = value;
                RaisePropertyChanged();
            }
        }

        private string kliensTelSzam;

        public string KliensTelSzam
        {
            get { return kliensTelSzam; }
            set
            {
                kliensTelSzam = value;
                RaisePropertyChanged();
            }
        }

        private string kliensSzulDatum;

        public string KliensSzulDatum
        {
            get { return kliensSzulDatum; }
            set
            {
                kliensSzulDatum = value;
                RaisePropertyChanged();
            }
        }

        private string kliensNev;

        public string KliensNev
        {
            get { return kliensNev; }
            set
            {
                kliensNev = value;
                RaisePropertyChanged();
            }
        }

        private string berletKezdetiNap;

        public string BerletKezdetiNap
        {
            get { return berletKezdetiNap; }
            set
            {
                berletKezdetiNap = value;
                RaisePropertyChanged();
            }
        }

        private bool berletErvenyesseg;

        public bool BerletErvenyesseg
        {
            get { return berletErvenyesseg; }
            set
            {
                berletErvenyesseg = value;
                RaisePropertyChanged();
            }
        }

        private string berletNapokSzama;

        public string BerletNapokSzama
        {
            get { return berletNapokSzama; }
            set
            {
                berletNapokSzama = value;
                RaisePropertyChanged();
            }
        }


        private string berletBelepesekSzama;

        public string BerletBelepesekSzama
        {
            get { return berletBelepesekSzama; }
            set
            {
                berletBelepesekSzama = value;
                RaisePropertyChanged();
            }
        }

        private KliensBerlet kivalasztottKliens;

        public KliensBerlet KivalasztottKliens
        {
            get { return kivalasztottKliens; }
            set
            {
                kivalasztottKliens = value;
                RaisePropertyChanged();
            }
        }


        private string berletEladasiAr;

        public string BerletEladasiAr
        {
            get { return berletEladasiAr; }
            set
            {
                berletEladasiAr = value;
                RaisePropertyChanged();
            }
        }

        private List<KliensBerlet> kliensAdatok;

        public List<KliensBerlet> KliensAdatok
        {
            get { return kliensAdatok; }
            set
            {
                kliensAdatok = value;
                RaisePropertyChanged();

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


        private void CloseCommandExecute()
        {
            ViewService.CloseDialog(this);
        }

        public string Header => "BelepesekKovetese";

        public RelayCommand CloseCommand { get; set; }
        public RelayCommand KeresesKliensCommand { get; set; }
        public RelayCommand KeresettAdatMegjelenites { get; set; }
        public RelayCommand BelepesKliensCommand { get; set; }
    }
}
