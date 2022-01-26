using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class InstrukcijaModel
    {
        public int Id { get; set; }

        public string Ime { get; set; }


        public string Prezime { get; set; }


        public DateOnly Dat_Odr { get; set; }


        public TimeOnly Termin { get; set; }

        public int Br_Cas { get; set; }

        public int Br_Ucen { get; set; }
        
        public string Biljeske { get; set; }

    }
}
