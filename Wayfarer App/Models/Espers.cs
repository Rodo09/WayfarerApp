using System;
using System.Collections.Generic;

namespace Wayfarer_App.Models
{
    public partial class Espers
    {
        public Espers()
        {
            OwnedEspers = new HashSet<OwnedEspers>();
        }

        public int EsperId { get; set; }
        public string Name { get; set; }
        public int RarityId { get; set; }
        public string EsperImage { get; set; }

        public virtual Rarities Rarity { get; set; }
        public virtual ICollection<OwnedEspers> OwnedEspers { get; set; }
    }
}
