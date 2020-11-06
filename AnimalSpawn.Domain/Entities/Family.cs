using System;
using System.Collections.Generic;

namespace AnimalSpawn.Domain.Entities
{
    public partial class Family:BaseEntity
    {
        public Family()
        {
            Animal = new HashSet<Animal>();
        }

        public string CommonName { get; set; }
        public string Code { get; set; }

        public virtual ICollection<Animal> Animal { get; set; }
    }
}
