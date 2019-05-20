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
    public class BerletekListazasaViewModel : ViewModelBase, IBerletekListazasaContent, INotifyPropertyChanged
    {
        
        public static FitnesszController fitnesszController;
        public BerletekListazasaViewModel()
        {

            this.berletek = Data.fitnesszController.GetBerletek();
           // this.OpenArticleTabCommand = new RelayCommand(this.OpenArticleTabExecute);

            // this.KeresesBerletCommand = new RelayCommand(this.KeresesKliensCommandExecute);
        }
       
        private void KeresesKliensCommandExecute()
        {
            // KivalasztottBerletek = Data.fitnesszController.KeresBerlet(KeresettBerlet);
          //  kivalasztottBerletek = Data.fitnesszController.KeresesBerlet();
        }
        public RelayCommand KeresesBerletCommand { get; set; }

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
        private string napokSzama;
        public string NapokSzama
        {
            get
            {
                return napokSzama;
            }
            set
            {
                this.napokSzama = value;
                this.Berletek = Data.fitnesszController.KeresBerletTipus(this.napokSzama);

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
        public string Header => "Berletek Listazasa";
    }
}
