using System;
using System.Collections.Generic;

namespace DATOS
{
    public partial class Arbitro
    {
        public Arbitro()
        {
            Partidos = new HashSet<Partido>();
        }

        public string? Funcion { get; set; }
        public string Id { get; set; } = null!;

        public virtual Persona IdNavigation { get; set; } = null!;
        public virtual ICollection<Partido> Partidos { get; set; }
    }
}
