using System;
using System.Collections.Generic;

namespace Data
{
    public partial class Jugador
    {
        public string? Numdorsal { get; set; }
        public string Id { get; set; } = null!;
        public string? Codequipo { get; set; }

        public virtual Equipo? CodequipoNavigation { get; set; }
        public virtual Persona IdNavigation { get; set; } = null!;
        public virtual Estadistica? Estadistica { get; set; }
    }
}
