using System;
using System.Collections.Generic;

namespace Wayfarer_App.Models
{
    public partial class Units
    {
        public Units()
        {
            OwnedUnits = new HashSet<OwnedUnits>();
        }

        public int UnitId { get; set; }
        public string Name { get; set; }
        public int RarityId { get; set; }
        public string Faction { get; set; }
        public string Job1 { get; set; }
        public string Job2 { get; set; }
        public string Job3 { get; set; }
        public string UnitImage { get; set; }

        public virtual Rarities Rarity { get; set; }
        public virtual ICollection<OwnedUnits> OwnedUnits { get; set; }
    }
}
