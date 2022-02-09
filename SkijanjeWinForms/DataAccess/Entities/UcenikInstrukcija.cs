using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess
{
    public partial class UcenikInstrukcija
    {
        public int Ucenikid { get; set; }
        public int Instrukcijaid { get; set; }

        public virtual Instrukcija Instrukcija { get; set; }
        public virtual Ucenik Ucenik { get; set; }
    }
}
