using System;
using System.Collections.Generic;

namespace AnimalSpawn.Domain.Entities
{
    public partial class ProtectedArea:BaseEntity
    {
        public ProtectedArea()
        {
            Researcher = new HashSet<Researcher>();
            RfidTag = new HashSet<RfidTag>();
        }

        public string Name { get; set; }
        public int? Design { get; set; }
        public string Type { get; set; }
        public decimal? Area { get; set; }
        public int? YearEnactment { get; set; }
        public int CountryId { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<Researcher> Researcher { get; set; }
        public virtual ICollection<RfidTag> RfidTag { get; set; }
    }
}
