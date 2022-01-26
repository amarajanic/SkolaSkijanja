using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess
{
    public partial class OpremaUcenik
    {
        public int Id { get; set; }
        public int? Kolicina { get; set; }
        public DateTime? DatIzd { get; set; }
        public int Opremaid { get; set; }
        public int Ucenikid { get; set; }
        public int? Instrukcijaid { get; set; }

        public virtual Instrukcija Instrukcija { get; set; }
        public virtual Oprema Oprema { get; set; }
        public virtual Ucenik Ucenik { get; set; }
    }
}
