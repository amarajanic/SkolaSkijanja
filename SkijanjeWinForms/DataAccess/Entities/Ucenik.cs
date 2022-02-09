using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess
{
    public partial class Ucenik
    {
        public Ucenik()
        {
            OpremaUceniks = new HashSet<OpremaUcenik>();
            UcenikInstrukcijas = new HashSet<UcenikInstrukcija>();
        }

        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime? DatRodj { get; set; }
        public string Spol { get; set; }
        public string KontaktTel { get; set; }

        public virtual ICollection<OpremaUcenik> OpremaUceniks { get; set; }
        public virtual ICollection<UcenikInstrukcija> UcenikInstrukcijas { get; set; }
    }
}
