using System;
using System.Collections.Generic;

namespace AnimalSpawn.Domain.Entities
{
    public partial class Species:BaseEntity
    {
        public Species()
        {
            Animal = new HashSet<Animal>();
        }

        public string CommonName { get; set; }
        public string ScientificName { get; set; }
        public string Code { get; set; }
        public int? ConservationStatus { get; set; }
        public int? PopulationTrend { get; set; }
        public string HabitatEcology { get; set; }

        public virtual ICollection<Animal> Animal { get; set; }
    }
}
