using System;
using System.Collections.Generic;

namespace AnimalSpawn.Domain.Entities
{
    public partial class Photo:BaseEntity
    {
        public string FileName { get; set; }
        public string Url { get; set; }
        public int AnimalId { get; set; }

        public virtual Animal Animal { get; set; }
    }
}
