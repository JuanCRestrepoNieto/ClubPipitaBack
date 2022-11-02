using System;
using System.Collections.Generic;

namespace Data
{
    public partial class Partido
    {
        public Partido()
        {
            Partidojugados = new HashSet<Partidojugado>();
        }

        public string Codigo { get; set; } = null!;
        public DateTime? Fecha { get; set; }
        public string? Idarbrito { get; set; }
        public string? Codfasegrupo { get; set; }

        public virtual Fasegrupo? CodfasegrupoNavigation { get; set; }
        public virtual Arbitro? IdarbritoNavigation { get; set; }
        public virtual ICollection<Partidojugado> Partidojugados { get; set; }
    }
}
