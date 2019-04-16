using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitnessz.Model
{
    using System.ComponentModel.DataAnnotations;

    public class Belepesek
    {
        [Key]
        public int BelepesekId { get; set; }

        public string Datum { get; set; }

        public int KliensBerletId { get; set; }

        
    }
}
