using System;
using System.Collections.Generic;

namespace Wayfarer_App.Models
{
    public partial class OwnedUnits
    {
        public int OwnedUnitId { get; set; }
        public int UnitId { get; set; }
        public int UserId { get; set; }
        public int UnitLevel { get; set; }
        public int UnitAwakening { get; set; }
        public int UnitLimitBreak { get; set; }
        public int UnitJob1Level { get; set; }
        public int? UnitJob2Level { get; set; }
        public int? UnitJob3Level { get; set; }

        public virtual Units Unit { get; set; }
        public virtual Users User { get; set; }
    }
}
