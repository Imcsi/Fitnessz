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

namespace Fitnessz.ViewModel.UserControls
{
    public class KliensBerleteViewModel : ViewModelBase, IKliensBerleteContent
    {
        public static FitnesszController fitnesszController;
        public string Header =>"KliensBerlete";
         public KliensBerleteViewModel()
        {
            this.CloseCommand = new RelayCommand(this.CloseCommandExecute);
            this.HozzaadKliensBerleteCommand = new RelayCommand(this.HozzaadKliensBerleteCommandExecute);
        }
        public RelayCommand HozzaadKliensBerleteCommand { get; set; }

        private void HozzaadKliensBerleteCommandExecute()
        {
            Data.fitnesszController.KliensBerleteMentese(new KliensBerlet
            {
                KliensBerletId = 1,
                VonalKod = "",
                BerletId = berletTipus,
                NapokSzama = 1,
                KezdetiNap = "",
                BelepesekSzama = 1,
                EladasiAr = 23,
                KliensId = kliensId,
                Ervenyesseg=true,
                BelepesekId =1
            });
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

        public int KliensId
        {
            get
            {
                return kliensId;
            }
            set
            {
                this.kliensId = value;
                this.Kliensek = Data.fitnesszController.GetKliens(this.kliensId);

                this.RaisePropertyChanged();
            }
        }
        private int berletTipus;
        public int BerletTipus
        {
            get
            {
                return berletTipus;
            }
            set
            {
                this.berletTipus = value;
                this.Berletek = Data.fitnesszController.getBerletek(this.berletTipus);

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
