using Fitnessz.Common.FitnesszContentTypes;
using Fitnessz.Common.MVVM;
using Fitnessz.Logic;
using Fitnessz.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Fitnessz.ViewModel.UserControls
{
    public class UgyfelekListazasaViewModel : ViewModelBase, IUgyfelekListazasaContent, INotifyPropertyChanged

    {
        public static FitnesszController fitnesszController;
        public UgyfelekListazasaViewModel()
        {
            
            this.kliens = Data.fitnesszController.GetKliensek();
            
        }
        public string Header => "Kliensek Listazasa";

        private List<Fitnessz.Model.Kliens> kliens;

        public List<Fitnessz.Model.Kliens> Kliens
        {
            get
            {
                return kliens;
            }
            set
            {
                kliens = value;
                this.RaisePropertyChanged();
            }
        }

        private string kliensNeve;

        public string KliensNeve
        {
            get { return kliensNeve; }
            set
            {
                kliensNeve = value;
                this.RaisePropertyChanged();
            }
        }

        private string kliensSzuletesiDatum;

        public string KliensSzuletesiDatuma
        {
            get { return kliensSzuletesiDatum; }
            set
            {
                kliensSzuletesiDatum = value;
                this.RaisePropertyChanged();
            }
        }
        private string kliensTelefonszam;

        public string KliensTelefonszam
        {
            get { return kliensTelefonszam; }
            set
            {
                kliensTelefonszam = value;
                this.RaisePropertyChanged();
            }
        }
        private string vonalKod;
        public string VonalKod
        {
            get { return vonalKod; }
            set
            {
                vonalKod = value;
                this.RaisePropertyChanged();
            }
        }

        private string nem;
        public string Nem
        {
            get { return nem; }
            set
            {
                nem = value;
                this.RaisePropertyChanged();
            }
        }




        /*
        public ICommand PrintCommand { get; private set; }

        public void PrintGrid(object param)
        {
            PrintDialog printDialog = new PrintDialog();

            if (printDialog.ShowDialog() == false)
                return;

            string documentTitle = "Test Document";
            Size pageSize = new Size(printDialog.PrintableAreaWidth, printDialog.PrintableAreaHeight);

            CustomDataGridDocumentPaginator paginator = new CustomDataGridDocumentPaginator(param as DataGrid, documentTitle, pageSize, new Thickness(30, 20, 30, 20));
            printDialog.PrintDocument(paginator, "Grid");
        }
        */



        string FitnesszContent.Header => throw new NotImplementedException();
    }


}
