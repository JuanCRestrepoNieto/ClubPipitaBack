using System;
using System.Collections.Generic;

namespace DATOS
{
    public partial class Fasegrupo
    {
        public Fasegrupo()
        {
            Partidos = new HashSet<Partido>();
        }

        public string Codigo { get; set; } = null!;
        public DateTime? Fechainicio { get; set; }
        public DateTime? Fechafinal { get; set; }
        public string? Codfasegrupo { get; set; }

        public virtual Torneo? CodfasegrupoNavigation { get; set; }
        public virtual ICollection<Partido> Partidos { get; set; }
    }
}
