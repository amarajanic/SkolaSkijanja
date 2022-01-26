using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess
{
    public partial class Model
    {
        public Model()
        {
            Opremas = new HashSet<Oprema>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Oprema> Opremas { get; set; }
    }
}
