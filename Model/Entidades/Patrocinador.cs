using System;
using System.Collections.Generic;

namespace Data
{
    public partial class Patrocinador
    {
        public Patrocinador()
        {
            Codequipos = new HashSet<Equipo>();
        }

        public string Id { get; set; } = null!;
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }

        public virtual ICollection<Equipo> Codequipos { get; set; }
    }
}
