using Fitnessz.Common.MVVM;
using Fitnessz.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitnessz.ViewModel
{
    public class MainWindowViewModel:ViewModelBase
    {
        public static FitnesszController FitnesszController;

        public MainWindowViewModel()
        {
            
            this.CloseCommand = new RelayCommand(this.CloseCommandExecute);
            Data.FitnesszController.GetBelepesek();
        }

        public RelayCommand CloseCommand { get; set; }

        public void CloseCommandExecute()
        {
            ViewService.CloseDialog(this);
        }
    
}
}
