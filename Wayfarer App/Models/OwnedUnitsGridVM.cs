using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wayfarer_App.Models
{
    public class OwnedUnitsGridVM
    {
        public int OwnedUnitId { get; set; }
        public string UnitImage { get; set; }
        public string Name { get; set; }
        public string Faction { get; set; }
        public string RarityImage { get; set; }
        public int UnitLimitBreak { get; set; }
        public int UnitAwakening { get; set; }
        public int UnitLevel { get; set; }
        public string Job1 { get; set; }
        public int UnitJob1Level { get; set; }
        public string Job2 { get; set; }
        public int? UnitJob2Level { get; set; }
        public string Job3 { get; set; }
        public int? UnitJob3Level { get; set; }
        public int UserId { get; set; }
    }
}
