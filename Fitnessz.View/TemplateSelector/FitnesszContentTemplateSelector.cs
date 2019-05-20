using Fitnessz.Common.FitnesszContentTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Fitnessz.View.TemplateSelector
{
    public class FitnesszContentTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item is IKliensContent)
            {
                return Application.Current.MainWindow.TryFindResource("KliensViewTemplate") as DataTemplate;
            }

            else if(item is IBerletTipusContent)
            {
                return Application.Current.MainWindow.TryFindResource("BerletTipusViewTemplate") as DataTemplate;
            }
            else if(item is IKliensBerleteContent)
            {
                return Application.Current.MainWindow.TryFindResource("KliensBerleteViewTemplate") as DataTemplate;
            }
            
            else if (item is IBerletHosszabbitasContent)
            {
                return Application.Current.MainWindow.TryFindResource("BerletHosszabbitasViewTemplate") as DataTemplate;
            }

            else if (item is IUgyfelekListazasaContent)
            {
                return Application.Current.MainWindow.TryFindResource("UgyfelekListazasaViewTemplate") as DataTemplate;
            }
            else if (item is IBerletekListazasaContent)
            {
                return Application.Current.MainWindow.TryFindResource("BerletekListazasaViewTemplate") as DataTemplate;
            }
            else if (item is IBelepesekListazasaContent)
            {
                return Application.Current.MainWindow.TryFindResource("BelepesekListazasaViewTemplate") as DataTemplate;
            }
            else if (item is IBelepesekKoveteseContent)
            {
                return Application.Current.MainWindow.TryFindResource("BelepesekKoveteseViewTemplate") as DataTemplate;
            }

           



            return base.SelectTemplate(item, container);
        }
    }
}
