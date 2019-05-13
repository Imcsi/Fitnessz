﻿using Fitnessz.Common.FitnesszContentTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Fitnessz.View.TemplateSelector
{
    public class FitnesszHeaderTemplateSelector: DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item is IKliensContent)
            {
                return Application.Current.MainWindow.TryFindResource("DefaultHeaderTemplate") as DataTemplate;
            }
            if (item is IBerletContent)
            {
                return Application.Current.MainWindow.TryFindResource("DefaultHeaderTemplate") as DataTemplate;
            }
            if(item is IKliensBerleteContent)
            {
                return Application.Current.MainWindow.TryFindResource("DefaultHeaderTemplate") as DataTemplate;
            }
                return base.SelectTemplate(item, container);

        }
    }
}
