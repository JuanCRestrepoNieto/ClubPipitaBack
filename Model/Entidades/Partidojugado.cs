using System;
using System.Collections.Generic;

namespace DATOS
{
    public partial class Partidojugado
    {
        public string Codigopartido { get; set; } = null!;
        public string Codigoequipo { get; set; } = null!;
        public string? Marcador { get; set; }
        public string? Ganador { get; set; }

        public virtual Equipo CodigoequipoNavigation { get; set; } = null!;
        public virtual Partido CodigopartidoNavigation { get; set; } = null!;
    }
}
