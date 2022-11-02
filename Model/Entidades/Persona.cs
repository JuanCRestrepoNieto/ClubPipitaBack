using System;
using System.Collections.Generic;

namespace Data
{
    public partial class Persona
    {
        public string Id { get; set; } = null!;
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Telefono { get; set; }
        public string? Usuario { get; set; }

        public virtual Usuario? UsuarioNavigation { get; set; }
        public virtual Arbitro? Arbitro { get; set; }
        public virtual Dt? Dt { get; set; }
        public virtual Jugador? Jugador { get; set; }
    }
}
