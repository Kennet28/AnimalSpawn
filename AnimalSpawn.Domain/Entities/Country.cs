using System;
using System.Collections.Generic;

namespace AnimalSpawn.Domain.Entities
{
    public partial class Country:BaseEntity
    {
        public Country()
        {
            ProtectedArea = new HashSet<ProtectedArea>();
        }

        public string Name { get; set; }
        public string Code { get; set; }
        public string Isocode { get; set; }
        public int? Region { get; set; }

        public virtual ICollection<ProtectedArea> ProtectedArea { get; set; }
    }
}
