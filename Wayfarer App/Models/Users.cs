using System;
using System.Collections.Generic;

namespace Wayfarer_App.Models
{
    public partial class Users
    {
        public Users()
        {
            GuildBattleComps = new HashSet<GuildBattleComps>();
            OwnedEspers = new HashSet<OwnedEspers>();
            OwnedUnits = new HashSet<OwnedUnits>();
            OwnedVisions = new HashSet<OwnedVisions>();
        }

        public int UserId { get; set; }
        public int RoleId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }

        public virtual Roles Role { get; set; }
        public virtual ICollection<GuildBattleComps> GuildBattleComps { get; set; }
        public virtual ICollection<OwnedEspers> OwnedEspers { get; set; }
        public virtual ICollection<OwnedUnits> OwnedUnits { get; set; }
        public virtual ICollection<OwnedVisions> OwnedVisions { get; set; }
    }
}
