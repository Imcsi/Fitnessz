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
    public class BerletTipusViewModel : ViewModelBase, INotifyPropertyChanged, IBerletTipusContent
    {
        public static FitnesszController fitnesszController;
        public BerletTipusViewModel()
        {
            this.CloseCommand = new RelayCommand(this.CloseCommandExecute);
            this.HozzaadBerletTipusCommand = new RelayCommand(this.HozzaadBerletTipusCommandExecute);
            this.KeresesBerletTipusCommand = new RelayCommand(this.KeresesBerletTipusCommandExecute);
            this.ModositasBerletTipusCommand = new RelayCommand(this.ModositasBerletTipusCommandExecute);
            this.TorlesBerletTipusCommand = new RelayCommand(this.TorlesBerletTipusCommandExecute);
            this.KeresettAdatMegjelenites = new RelayCommand(this.KeresettAdatMegjelenitesExecute);
        }

        private void TorlesBerletTipusCommandExecute()
        {
            Data.fitnesszController.BerletTipusAdatTorles(KivalasztottBerletTipus);
            KeresesBerletTipusCommandExecute();
            TorolTextBoxElemek();
        }

        private void ModositasBerletTipusCommandExecute()
        {
            Data.fitnesszController.BerletTipusAdatModositas(new Berlet
            {
                BerletId = kivalasztottBerletTipus.BerletId,
                Tipus = BerletTipus,
                Ar = Convert.ToInt32(BerletAr),
                BelepesekSzama = Convert.ToInt32(BerletBelepesekSzama),
                NapokSzama = Convert.ToInt32(BerletNapokSzama),
                NapontaHanyszor = Convert.ToInt32(BerletNapontaHanyszor),
                Hanyig= Convert.ToInt32(BerletHanyig),
                Hanytol = Convert.ToInt32(BerletHanytol)



            });

            KeresesBerletTipusCommandExecute();
            TorolTextBoxElemek();
        }

        private void KeresettAdatMegjelenitesExecute()
        {
            BerletTipus = KivalasztottBerletTipus.Tipus;
            BerletAr = KivalasztottBerletTipus.Ar.ToString();
            BerletBelepesekSzama = KivalasztottBerletTipus.BelepesekSzama.ToString();
            BerletHanyig = KivalasztottBerletTipus.Hanyig.ToString();
            BerletHanytol = KivalasztottBerletTipus.Hanytol.ToString();
            BerletNapokSzama = KivalasztottBerletTipus.NapokSzama.ToString();
            BerletNapontaHanyszor = KivalasztottBerletTipus.NapontaHanyszor.ToString();

        }

        private void KeresesBerletTipusCommandExecute()
        {
            BerletTipusLista = Data.fitnesszController.KeresBerletTipus(KeresettBerletTipus);
        }

        private void HozzaadBerletTipusCommandExecute()
        {
            Data.fitnesszController.BerletTipusMentese(new Berlet
            {
                Tipus = BerletTipus,
                Ar = Convert.ToInt32(BerletAr), 
                BelepesekSzama = Convert.ToInt32(BerletBelepesekSzama),
                Hanyig = Convert.ToInt32(BerletHanyig),
                Hanytol = Convert.ToInt32(BerletHanytol),
                NapokSzama = Convert.ToInt32(BerletNapokSzama),
                NapontaHanyszor = Convert.ToInt32(BerletNapontaHanyszor)

            });
            TorolTextBoxElemek();
        }

        private void CloseCommandExecute()
        {
            ViewService.CloseDialog(this);
        }

        private string keresettBerletTipus;

        public string KeresettBerletTipus
        {
            get { return keresettBerletTipus; }
            set
            {
                keresettBerletTipus = value;
                this.RaisePropertyChanged();
            }
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

        private void TorolTextBoxElemek()
        {
            BerletTipus = "";
            BerletAr = "";
            BerletNapokSzama = "";
            BerletNapontaHanyszor = "";
            BerletBelepesekSzama = "";
            BerletHanytol = "";
            BerletHanyig = "";

        }

        private string berletHanyig;

        public string BerletHanyig
        {
            get { return berletHanyig; }
            set { berletHanyig = value;
                RaisePropertyChanged();
            }
        }


        private string berletHanytol;

        public string BerletHanytol
        {
            get { return berletHanytol; }
            set { berletHanytol = value;
                RaisePropertyChanged();
            }
        }


        private string berletBelepesekSzama;

        public string BerletBelepesekSzama
        {
            get { return berletBelepesekSzama; }
            set { berletBelepesekSzama = value;
                RaisePropertyChanged();
            }
        }


        private string berletNapontaHanyszor;

        public string BerletNapontaHanyszor
        {
            get { return berletNapontaHanyszor; }
            set { berletNapontaHanyszor = value;
                RaisePropertyChanged();
            }
        }


        private string berletNapokSzama;

        public string BerletNapokSzama
        {
            get { return berletNapokSzama; }
            set { berletNapokSzama = value;
                RaisePropertyChanged();
            }
        }


        private string berletAr;

        public string BerletAr
        {
            get { return berletAr; }
            set { berletAr = value;
                RaisePropertyChanged();
            }
        }


        private string berletTipus;

        public string BerletTipus
        {
            get { return berletTipus; }
            set { berletTipus = value;
                RaisePropertyChanged();
            }
        }


        private Berlet kivalasztottBerletTipus;

        public Berlet KivalasztottBerletTipus
        {
            get { return kivalasztottBerletTipus; }
            set
            {
                kivalasztottBerletTipus = value;
                RaisePropertyChanged();
            }
        }

        public string Header => "BerletTipus";

        public RelayCommand CloseCommand { get; set; }
        public RelayCommand HozzaadBerletTipusCommand { get; set; }
        public RelayCommand KeresesBerletTipusCommand { get; set; }
        public RelayCommand KeresettAdatMegjelenites { get; set; }
        public RelayCommand ModositasBerletTipusCommand { get; set; }
        public RelayCommand TorlesBerletTipusCommand { get; set; }
    }
}
