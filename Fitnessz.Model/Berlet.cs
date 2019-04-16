using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitnessz.Model
{
    using System.ComponentModel.DataAnnotations;
    public class Berlet
    {

        [Key]
        public int BerletId { get; set; }

        public string Tipus { get; set; }

        public int Ar { get; set; }

        public string NapokSzama { get; set; }

        public string NapontaHanyszor { get; set; }

        public string BelepesekSzama { get; set; }

        public string Hanytol { get; set; }

        public string Hanyig { get; set; }

        


    }
}
