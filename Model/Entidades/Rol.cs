using System;
using System.Collections.Generic;

namespace Data
{
    public partial class Rol
    {
        public Rol()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public string Codigo { get; set; } = null!;
        public string? Nombrerol { get; set; }
        public string? Descripcion { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
