using System;
using System.Collections.Generic;

namespace AnimalSpawn.Domain.Entities

{
    public partial class Sighting : BaseEntity
    {
        public int Id { get; set; }
        public DateTime RegisterDate { get; set; }
        public string Observation { get; set; }
        public int? AnimalId { get; set; }
        public int? ResearcherId { get; set; }
        public DateTime? CreateAt { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public int? UpdatedBy { get; set; }
        public bool? Status { get; set; }

        public virtual Animal Animal { get; set; }
        public virtual Researcher Researcher { get; set; }
    }
}
