using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitnessz.Model
{
    using System.ComponentModel.DataAnnotations;

    public class KliensBerlet
    {
        [Key]
        public int KliensBerletId { get; set; }

        public string VonalKod { get; set; }

        public int BerletId { get; set; }

        public int NapokSzama { get; set; }

        public string KezdetiNap { get; set; }

        public int BelepesekSzama { get; set; }

        public int EladasiAr { get; set; }

        public bool Ervenyesseg { get; set; }



        public int KliensId { get; set; }

        public int BelepesekId { get; set; }

    }
}
