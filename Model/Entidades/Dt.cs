using System;
using System.Collections.Generic;

namespace Data
{
    public partial class Dt
    {
        public string? Diplomados { get; set; }
        public string Id { get; set; } = null!;

        public virtual Persona IdNavigation { get; set; } = null!;
    }
}
