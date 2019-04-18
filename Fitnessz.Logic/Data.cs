using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitnessz.Logic
{
    public static class Data
    {
        static Data()
        {
            FitnesszController = new FitnesszController();
        }

        public static FitnesszController FitnesszController { get; set; }
    }
}
