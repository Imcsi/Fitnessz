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
            fitnesszController = new FitnesszController();
        }

        public static FitnesszController fitnesszController { get; set; }
    }
}
