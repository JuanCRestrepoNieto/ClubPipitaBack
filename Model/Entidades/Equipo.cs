using System;
using System.Collections.Generic;

namespace Data
{
    public partial class Equipo
    {
        public Equipo()
        {
            Jugadors = new HashSet<Jugador>();
            Partidojugados = new HashSet<Partidojugado>();
            Idpatrocinadors = new HashSet<Patrocinador>();
        }

        public string Codigo { get; set; } = null!;
        public string? Nombre { get; set; }

        public virtual ICollection<Jugador> Jugadors { get; set; }
        public virtual ICollection<Partidojugado> Partidojugados { get; set; }

        public virtual ICollection<Patrocinador> Idpatrocinadors { get; set; }
    }
}
