using System;
using System.Collections.Generic;

namespace AnimalSpawn.Domain.Entities
{
    public partial class RfidTag:BaseEntity
    {
        public string Tag { get; set; }
        public DateTime? DateEstablished { get; set; }
        public int ProtectedAreaId { get; set; }

        public virtual Animal IdNavigation { get; set; }
        public virtual ProtectedArea ProtectedArea { get; set; }
    }
}
