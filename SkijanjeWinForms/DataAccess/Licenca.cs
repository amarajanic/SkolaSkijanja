using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess
{
    public partial class Licenca
    {
        public int Id { get; set; }
        public string LicencaId { get; set; }
        public string NazivLicence { get; set; }
        public string Opis { get; set; }
        public int Instruktorid { get; set; }

        public virtual Instruktor Instruktor { get; set; }
    }
}
