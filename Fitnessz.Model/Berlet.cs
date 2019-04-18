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

        public int NapokSzama { get; set; }

        public int NapontaHanyszor { get; set; }

        public int BelepesekSzama { get; set; }

        public int Hanytol { get; set; }

        public int Hanyig { get; set; }







    }
}
