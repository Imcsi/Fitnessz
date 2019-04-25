using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitnessz.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Kliens
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int KliensId { get; set; }

        public string Nev { get; set; }

        public  string SzuletesiDatum { get; set; }
        
        public string TelSzam { get; set; }

        public string VonalKod { get; set; }

        public string  Nem { get; set; }

        public bool Inaktiv { get; set; }
    }
}
