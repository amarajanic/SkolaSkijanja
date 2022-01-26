using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class InstrukcijaDodajModel
    {
        public DateOnly Datum_Odr { get; set; }
        public TimeOnly Termin { get; set; }
        public int Broj_Cas { get; set; }
        public string Biljeske { get; set; }
        public int InstruktorId { get; set; }
    }
}
