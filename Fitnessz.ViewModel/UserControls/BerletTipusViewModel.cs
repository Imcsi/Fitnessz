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
   public class BerletTipusViewModel:ViewModelBase, INotifyPropertyChanged, IBerletContent
    {
        public static FitnesszController fitnesszController;

        public BerletTipusViewModel()
        {
            this.CloseCommand = new RelayCommand(this.CloseCommandExecute);
            this.HozzaadBerletCommand = new RelayCommand(this.HozzaadBerletCommandExecute);
            this.KeresesBerletCommand = new RelayCommand(this.KeresesBerletTipusCommandExecute);
            this.KeresettAdatMegjelenites = new RelayCommand(this.KeresettAdatMegjelenitesExecute);
            this.ModositasBerletCommand = new RelayCommand(this.ModositasBerletTipusCommandExecute);
            this.TorlesBerletCommand = new RelayCommand(this.TorlesBerletTipusCommandExecute);
        }

        private void TorlesBerletTipusCommandExecute() 
        {
            Data.fitnesszController.BerletAdatTorles(KivalasztottBerletTipus);
            KeresesBerletTipusCommandExecute();
            TorolTextBoxElemek();
        }

        private void ModositasBerletTipusCommandExecute()
        {
            Data.fitnesszController.BerletAdatModositas(new Berlet
            {
                NapokSzama = BerletNapokSzama,
                KezdetiNap = BerletKezdetiNap,
                BelepesekSzama = BerletbelepesekSzama,
                Ar = BerletAra,
                Hanytol = BerletHanytol,
                Hanyig = BerletHanyig
            });
            KeresesBerletTipusCommandExecute();
            TorolTextBoxElemek();
        }


      

        private void TorolTextBoxElemek()
        {
            BerletNapokSzama = 0;
            BerletKezdetiNap = "";
            BerletbelepesekSzama = 0;
            BerletAra = 0;
            BerletHanytol = 0;
            BerletHanyig = 0;

        }

        private void KeresettAdatMegjelenitesExecute()
        {

            BerletNapokSzama = KivalasztottBerletTipus.NapokSzama;
            BerletKezdetiNap = KivalasztottBerletTipus.KezdetiNap;
            BerletbelepesekSzama = KivalasztottBerletTipus.BelepesekSzama;
            BerletAra = KivalasztottBerletTipus.Ar;
            BerletHanytol = KivalasztottBerletTipus.Hanytol;
            BerletHanyig = KivalasztottBerletTipus.Hanyig;


        }

        private int berletNapokSzama;

        public int BerletNapokSzama
        {
            get { return berletNapokSzama; }
            set
            {
                berletNapokSzama = value;
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


        private Berlet kivalasztottBerlet;

        public Berlet KivalasztottBerletTipus
        {
            get { return kivalasztottBerlet; }
            set
            {
                kivalasztottBerlet = value;
                RaisePropertyChanged();
            }
        }


        private void KeresesBerletTipusCommandExecute()
        {
            BerletTipusLista = Data.fitnesszController.KeresBerlet(KeresettBerletId);
        }

        private List<Berlet> berletTipusLista;

        public List<Berlet> BerletTipusLista
        {
            get { return berletTipusLista; }
            set
            {
                berletTipusLista = value;
                RaisePropertyChanged();

            }
        }



        private int berletbelepesekSzama;

        public int BerletbelepesekSzama
        {
            get { return berletbelepesekSzama; }
            set
            {
                berletbelepesekSzama = value;
                this.RaisePropertyChanged();
            }
        }

        private int keresettBerletId;

        public int KeresettBerletId
        {
            get { return keresettBerletId; }
            set
            {
                keresettBerletId = value;
                this.RaisePropertyChanged();
            }
        }

        private int berletHanytol;

        public int BerletHanytol
        {
            get { return berletHanytol; }
            set
            {
                berletHanytol = value;
                this.RaisePropertyChanged();
            }
        }

        private int berletHanyig;

        public int BerletHanyig
        {
            get { return berletHanyig; }
            set
            {
                berletHanyig = value;
                this.RaisePropertyChanged();
            }
        }

        private int berletAra;

        public int BerletAra
        {
            get { return berletAra; }
            set
            {
                berletAra = value;
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

       




        private void HozzaadBerletCommandExecute()
        {
            Data.fitnesszController.BerletekMentese(new Berlet
            {
                NapokSzama = BerletNapokSzama,
                KezdetiNap = BerletKezdetiNap,
                BelepesekSzama = BerletbelepesekSzama,
                Ar = BerletAra,
                Hanytol = BerletHanytol,
                Hanyig=BerletHanyig


            });
        }





        public RelayCommand CloseCommand { get; set; }

        public RelayCommand HozzaadBerletCommand { get; set; }
        public RelayCommand KeresesBerletCommand { get; set; }
        public RelayCommand KeresettAdatMegjelenites { get; }
        public RelayCommand ModositasBerletCommand { get; private set; }
        public RelayCommand TorlesBerletCommand { get; }

        public string Header => "Berletek";

        public void CloseCommandExecute()
        {
            ViewService.CloseDialog(this);
        }
    }
}
