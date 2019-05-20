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
    public class BelepesekListazasaViewModel: ViewModelBase, IBelepesekListazasaContent, INotifyPropertyChanged
    {
        public static FitnesszController fitnesszController;
        public BelepesekListazasaViewModel()
        {

            this.belepes = Data.fitnesszController.GetBelepesek();
        }
        private List<Belepes> belepes;

        public List<Belepes> Belepes
        {
            get { return belepes; }
            set
            {
                belepes = value;
                this.RaisePropertyChanged();
            }
        }
        public string Header => "Belepesek Listazasa";
    }

    
    
}
