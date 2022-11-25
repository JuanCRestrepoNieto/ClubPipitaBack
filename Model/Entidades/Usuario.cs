using System;
using System.Collections.Generic;

namespace Data
{
    public partial class Usuario
    {
        public Usuario()
        {
            Personas = new HashSet<Persona>();
        }

        public string Correo { get; set; } = null!;
        public string? Contarsena { get; set; }
        public string? CodRol { get; set; }

        public virtual Rol? CodRolNavigation { get; set; }
        public virtual ICollection<Persona>? Personas { get; set; }
    }
}
