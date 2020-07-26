using System;
using System.Collections.Generic;

namespace Wayfarer_App.Models
{
    public partial class Visions
    {
        public Visions()
        {
            OwnedVisions = new HashSet<OwnedVisions>();
        }

        public int VisionId { get; set; }
        public string Name { get; set; }
        public int RarityId { get; set; }
        public string MaxLvlBestowedEffect { get; set; }
        public string MaxLvlPartyAbility { get; set; }
        public string VisionImage { get; set; }

        public virtual Rarities Rarity { get; set; }
        public virtual ICollection<OwnedVisions> OwnedVisions { get; set; }
    }
}
