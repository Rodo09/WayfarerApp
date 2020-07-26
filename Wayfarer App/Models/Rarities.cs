using System;
using System.Collections.Generic;

namespace Wayfarer_App.Models
{
    public partial class Rarities
    {
        public Rarities()
        {
            Espers = new HashSet<Espers>();
            Units = new HashSet<Units>();
            Visions = new HashSet<Visions>();
        }

        public int RarityId { get; set; }
        public string RarityName { get; set; }
        public string RarityImage { get; set; }

        public virtual ICollection<Espers> Espers { get; set; }
        public virtual ICollection<Units> Units { get; set; }
        public virtual ICollection<Visions> Visions { get; set; }
    }
}
