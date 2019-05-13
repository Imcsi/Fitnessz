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
using System.Windows;
using System.Windows.Controls;

namespace Fitnessz.ViewModel.UserControls
{
    public class BerletHosszabbitasViewModel : ViewModelBase, INotifyPropertyChanged, IBerletHosszabbitasContent
    {
        public static FitnesszController fitnesszController;
        public BerletHosszabbitasViewModel()
        {
            this.CloseCommand = new RelayCommand(this.CloseCommandExecute);
            this.KeresesBerletCommand = new RelayCommand(this.KeresesBerletCommandExecute);
            this.KeresettAdatMegjelenites = new RelayCommand(this.KeresettAdatMegjelenitesExecute);
            this.HosszabitBelepesSzam = new RelayCommand(this.HosszabitBelepesSzamCommandExecute);
            this.HosszabbitIdotartam = new RelayCommand(this.HosszabbitIdotartamCommandExecute);

            Idotartam = DateTime.Now;

        }

        private void HosszabbitIdotartamCommandExecute()
        {
            if (BelepesSzam != 0)
            {
                HosszabitBelepesSzamCommandExecute();
                KeresettAdatMegjelenitesExecute();
                BelepesSzam = 0;

            }
            else
            {
                Data.fitnesszController.IdotartamNoveles(KivalasztottBerlet, Idotartam);
                KeresettAdatMegjelenitesExecute();
                Idotartam = DateTime.Now;
            }
            //frissit talalatok
            KeresesBerletCommandExecute();
        }

        private void HosszabitBelepesSzamCommandExecute()
        {

            Data.fitnesszController.BelepesSzamNoveles(KivalasztottBerlet, BelepesSzam);
            KeresettAdatMegjelenitesExecute();
        }

        private DateTime idotartam;

        public DateTime Idotartam
        {
            get { return idotartam; }
            set
            {
                idotartam = value;
                RaisePropertyChanged();
            }
        }


        private int belepesSzam;

        public int BelepesSzam
        {
            get { return belepesSzam; }
            set
            {
                belepesSzam = value;
                RaisePropertyChanged();
            }
        }



        private void KeresesBerletCommandExecute()
        {
            BerletLista = Data.fitnesszController.KeresesBerlet(KeresettBerlet);
        }

        private void KeresettAdatMegjelenitesExecute()
        {

            BerletEladasiAr = KivalasztottBerlet.EladasiAr.ToString();
            BerletBelepesekSzama = KivalasztottBerlet.BelepesekSzama.ToString();
            BerletNapokSzama = KivalasztottBerlet.NapokSzama.ToString();
            BerletErvenyesseg = KivalasztottBerlet.Ervenyesseg;
            BerletKezdetiNap = KivalasztottBerlet.KezdetiNap.ToString();

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

        private KliensBerlet kivalasztottBerlet;

        public KliensBerlet KivalasztottBerlet
        {
            get { return kivalasztottBerlet; }
            set
            {
                kivalasztottBerlet = value;
                RaisePropertyChanged();
            }
        }

        private List<KliensBerlet> berletLista;

        public List<KliensBerlet> BerletLista
        {
            get { return berletLista; }
            set
            {
                berletLista = value;
                RaisePropertyChanged();

            }
        }

        private string keresettBerlet;

        public string KeresettBerlet
        {
            get { return keresettBerlet; }
            set
            {
                keresettBerlet = value;
                this.RaisePropertyChanged();
            }
        }


        private void CloseCommandExecute()
        {
            ViewService.CloseDialog(this);
        }

        public string Header => "BerletHosszabbitas";

        public RelayCommand CloseCommand { get; set; }
        public RelayCommand KeresesBerletCommand { get; set; }
        public RelayCommand KeresettAdatMegjelenites { get; set; }
        public RelayCommand HosszabitBelepesSzam { get; private set; }
        public RelayCommand HosszabbitIdotartam { get; }
        public string Title { get; private set; }

    }
}
