using System;
using System.Collections.Generic;

namespace AnimalSpawn.Domain.Entities
{
    public partial class Genus:BaseEntity
    {
        public Genus()
        {
            Animal = new HashSet<Animal>();
        }

        public string Name { get; set; }
        public string Code { get; set; }

        public virtual ICollection<Animal> Animal { get; set; }
    }
}
