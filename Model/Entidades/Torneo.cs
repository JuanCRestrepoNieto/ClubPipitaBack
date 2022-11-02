using System;
using System.Collections.Generic;

namespace Data
{
    public partial class Torneo
    {
        public Torneo()
        {
            Fasegrupos = new HashSet<Fasegrupo>();
        }

        public string Codigo { get; set; } = null!;
        public DateTime? Fechainicio { get; set; }
        public DateTime? Fechafinal { get; set; }

        public virtual ICollection<Fasegrupo> Fasegrupos { get; set; }
    }
}
