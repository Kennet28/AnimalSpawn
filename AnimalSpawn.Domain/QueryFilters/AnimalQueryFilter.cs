using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalSpawn.Domain.QueryFilters
{
    public class AnimalQueryFilter
    {
        public string Name { get; set; }
        public int? Family { get; set; }
        public int? Specie { get; set; }
        public int? Genus { get; set; }
        public DateTime? CaptureDateMin { get; set; }
        public DateTime? CaptureDateMax { get; set; }
        public string RfTag { get; set; }
    }
}
