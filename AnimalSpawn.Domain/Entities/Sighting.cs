using System;
using System.Collections.Generic;

namespace AnimalSpawn.Domain.Entities
{
    public partial class Sighting:BaseEntity
    {
        public DateTime RegisterDate { get; set; }
        public string Observation { get; set; }
        public int? AnimalId { get; set; }
        public int? ResearcherId { get; set; }

        public virtual Animal Animal { get; set; }
        public virtual Researcher Researcher { get; set; }
    }
}
