using System;
using System.Collections.Generic;

namespace DATOS
{
    public partial class Estadistica
    {
        public string Idjugador { get; set; } = null!;
        public int? Cantamarrillas { get; set; }
        public int? Cantrojas { get; set; }
        public int? Cantgoles { get; set; }
        public int? Cantfaltas { get; set; }

        public virtual Jugador IdjugadorNavigation { get; set; } = null!;
    }
}
