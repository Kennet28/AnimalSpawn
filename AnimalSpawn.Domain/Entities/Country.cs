using System;
using System.Collections.Generic;

namespace AnimalSpawn.Domain.Entities

{
    public partial class Country
    {
        public Country()
        {
            ProtectedArea = new HashSet<ProtectedArea>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Isocode { get; set; }
        public int? Region { get; set; }
        public DateTime? CreateAt { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public int? UpdatedBy { get; set; }
        public bool? Status { get; set; }

        public virtual ICollection<ProtectedArea> ProtectedArea { get; set; }
    }
}
