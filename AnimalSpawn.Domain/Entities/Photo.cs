using System;
using System.Collections.Generic;

namespace AnimalSpawn.Domain.Entities

{
    public partial class Photo
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string Url { get; set; }
        public int AnimalId { get; set; }
        public DateTime? CreateAt { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public int? UpdatedBy { get; set; }
        public bool? Status { get; set; }

        public virtual Animal Animal { get; set; }
    }
}
