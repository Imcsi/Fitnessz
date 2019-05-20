using Fitnessz.Common.FitnesszContentTypes;
using Fitnessz.Common.MVVM;
using Fitnessz.Logic;
using Fitnessz.Model;
using Fitnessz.Model.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Fitnessz.ViewModel.UserControls
{
    public class KliensBerleteViewModel : ViewModelBase, IKliensBerleteContent
    {
        public static FitnesszController fitnesszController;
        public string Header =>"KliensBerlete";
         public KliensBerleteViewModel()
        {
            this.Kliensek = Data.fitnesszController.GetKliensek();
            this.Berletek = Data.fitnesszController.GetBerletek();
            this.CloseCommand = new RelayCommand(this.CloseCommandExecute);
            KezdetiIdo = DateTime.Now;
            this.HozzaadKliensBerleteCommand = new RelayCommand(this.HozzaadKliensBerleteCommandExecute);
        }
        private string kartyaSzam;

        public string KartyaSzam
        {
            get { return kartyaSzam; }
            set
            {
                kartyaSzam = value;
                RaisePropertyChanged();
            }
        }

        public RelayCommand HozzaadKliensBerleteCommand { get; set; }

        private void HozzaadKliensBerleteCommandExecute()
        {
            Data.fitnesszController.KliensBerleteMentese(new KliensBerlet
            {
                
                BerletId=berletId,
                VonalKod = Data.fitnesszController.GetVonalKod(kliensId),
                NapokSzama = Data.fitnesszController.GetBerletNapokSzama(berletId),
                KezdetiNap = KezdetiIdo.ToString(),
                BelepesekSzama = 0,
                EladasiAr = Data.fitnesszController.GetBerletAr(berletId),
                KliensId = kliensId,
                Ervenyesseg=ervenyesseg
            });
            TorolTextBoxElemek();
        }
        private void TorolTextBoxElemek()
        {
            KartyaSzam =" ";
            
        }
    
        public RelayCommand CloseCommand { get; set; }
        public void CloseCommandExecute()
        {
            ViewService.CloseDialog(this);
        }
        private int kliensId;
        private List<Fitnessz.Model.Kliens>kliensek;
        public List<Fitnessz.Model.Kliens> Kliensek
        {
            get
            {
                return kliensek;
            }
            set
            {
                kliensek = value;
                this.RaisePropertyChanged();
            }
        }
        private DateTime kezdetiIdo;
        private bool ervenyesseg=false;
        public DateTime KezdetiIdo
        {
            get { return kezdetiIdo; }
            set
            {
                kezdetiIdo = value;
                if (kezdetiIdo >= DateTime.Now)
                {
                    ervenyesseg = true;
                }
                else
                    ervenyesseg = false;
                 RaisePropertyChanged();
            }
            
        }
        private List<Kliens> kivalasztottKliensek;
        public List<Fitnessz.Model.Kliens> KivalasztottKliensek
        {
            get
            {
                return kivalasztottKliensek;
            }
            set
            {
                kivalasztottKliensek = value;
                this.RaisePropertyChanged();
            }
        }
        public int KliensId
        {
            get
            {
                return kliensId;
            }
            set
            {
                this.kliensId = value;

                
                this.KivalasztottKliensek = Data.fitnesszController.GetKliens(this.kliensId);

                this.RaisePropertyChanged();
            }
        }
        private List<Berlet> kivalasztottBerletek;
        public List<Fitnessz.Model.Berlet> KivalasztottBerletek
        {
            get
            {
                return kivalasztottBerletek;
            }
            set
            {
                kivalasztottBerletek = value;
                this.RaisePropertyChanged();
            }
        }
        private int berletId;
        public int BerletId
        {
            get
            {
                return berletId;
            }
            set
            {
                this.berletId = value;
                this.kivalasztottBerletek = Data.fitnesszController.GetBerlet(this.berletId);
                this.RaisePropertyChanged();
            }
        }
        private string berletTipus;
        public string BerletTipus
        {
            get
            {
                return berletTipus;
            }
            set
            {
                this.berletTipus = value;
                this.Berletek = Data.fitnesszController.KeresBerletTipus(this.berletTipus);

                this.RaisePropertyChanged();
            }
        }
        private List<Berlet> berletek;
        public List<Berlet> Berletek
        {
            get { return berletek; }
            set
            {
                berletek = value;

                this.RaisePropertyChanged();
            }
        }
    }
}
