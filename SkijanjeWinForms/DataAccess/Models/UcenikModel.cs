using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class UcenikModel
    {
        public int Id { get; set; }
        public string Ime { get; set; }

        public string Prezime { get; set; }
        public DateTime? Dat_Rodj { get; set; }
        public string Spol { get; set; }
        public string Kontakt_Tel { get; set; }
    }
}
