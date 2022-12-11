using System;
using System.Collections.Generic;

namespace Data
{
    public partial class Equipo
    {
        public string Codigo { get; set; } = null!;
        public string? Nombre { get; set; }

        public virtual ICollection<Jugador> Jugadors { get; set; }
        public virtual ICollection<Partidojugado> Partidojugados { get; set; }

        public virtual ICollection<Patrocinador> Idpatrocinadors { get; set; }
    }
}
