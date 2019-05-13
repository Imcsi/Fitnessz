using Fitnessz.Common.FitnesszContentTypes;
using Fitnessz.Common.MVVM;
using Fitnessz.Logic;
using Fitnessz.Model;
using Fitnessz.ViewModel.UserControls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Fitnessz.ViewModel
{
    public class MainWindowViewModel:ViewModelBase,INotifyPropertyChanged
    {
        public static FitnesszController fitnesszController;
        public KliensViewModel KliensViewModel { get; private set; }

        public MainWindowViewModel()
        {

            KliensViewModel kliensViewModel = new KliensViewModel();
          ;
            BerletHosszabbitasViewModel berletHosszabbitasViewModel = new BerletHosszabbitasViewModel();

            this.Contents = new ObservableCollection<FitnesszContent>();
            this.CloseCommand = new RelayCommand(this.CloseCommandExecute);

            this.Contents.Add(kliensViewModel);
           // this.selectedContent = kliensViewModel;

            BerletTipusViewModel berletTipusViewModel = new BerletTipusViewModel();
            this.Contents.Add(berletTipusViewModel);
            //this.selectedContent = berletTipusViewModel;

            this.Contents.Add(berletHosszabbitasViewModel);
            this.selectedContent = berletHosszabbitasViewModel;

            KliensBerleteViewModel kliensBerleteViewModel = new KliensBerleteViewModel();
            this.Contents.Add(kliensBerleteViewModel);

        }

        private FitnesszContent selectedContent;

        public FitnesszContent SelectedContent
        {
            get { return selectedContent; }
            set
            {
                selectedContent = value;
                this.RaisePropertyChanged();
            }
        }

        private ObservableCollection<FitnesszContent> contents;
        public ObservableCollection<FitnesszContent> Contents
        {
            get { return contents; }
            set
            {
                contents = value;
                this.RaisePropertyChanged();
            }
        }


        public RelayCommand CloseCommand { get; set; }


        public void CloseCommandExecute()
        {
            ViewService.CloseDialog(this);
        }

        

    }
}
