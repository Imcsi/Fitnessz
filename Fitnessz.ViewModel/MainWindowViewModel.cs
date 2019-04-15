using Fitnessz.Common.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitnessz.ViewModel
{
    public class MainWindowViewModel:ViewModelBase
    {
        //public static CatalogController CatalogController;

        public MainWindowViewModel()
        {
            //CatalogController = new CatalogController();
            this.CloseCommand = new RelayCommand(this.CloseCommandExecute);
        }

        public RelayCommand CloseCommand { get; set; }

        public void CloseCommandExecute()
        {
            ViewService.CloseDialog(this);
        }
    
}
}
