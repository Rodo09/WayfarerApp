using System;
using System.Collections.Generic;

namespace Wayfarer_App.Models
{
    public partial class OwnedVisions
    {
        public int OwnedVisionId { get; set; }
        public int VisionId { get; set; }
        public int UserId { get; set; }
        public int VisionLevel { get; set; }
        public int VisionLimitBreak { get; set; }

        public virtual Users User { get; set; }
        public virtual Visions Vision { get; set; }
    }
}
