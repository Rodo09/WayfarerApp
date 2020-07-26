using System;
using System.Collections.Generic;

namespace Wayfarer_App.Models
{
    public partial class OwnedEspers
    {
        public int OwnedEsperId { get; set; }
        public int EsperId { get; set; }
        public int UserId { get; set; }
        public int EsperLevel { get; set; }
        public int EsperAwakening { get; set; }

        public virtual Espers Esper { get; set; }
        public virtual Users User { get; set; }
    }
}
