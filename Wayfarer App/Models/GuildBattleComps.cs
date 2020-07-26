using System;
using System.Collections.Generic;

namespace Wayfarer_App.Models
{
    public partial class GuildBattleComps
    {
        public int Gbid { get; set; }
        public int UserId { get; set; }
        public int OwnedUnitIdslot1 { get; set; }
        public int OwnedUnitIdslot2 { get; set; }
        public int OwnedUnitIdslot3 { get; set; }
        public int OwnedEsperIdslot1 { get; set; }
        public int OwnedEsperIdslot2 { get; set; }
        public int OwnedEsperIdslot3 { get; set; }
        public int OwnedVisionIdslot1 { get; set; }
        public int OwnedVisionIdslot2 { get; set; }
        public int OwnedVisionIdslot3 { get; set; }

        public virtual Users User { get; set; }
    }
}
