using AnimalSpawn.Domain.Entities;
using AnimalSpawn.Domain.QueryFilters;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalSpawn.Domain.Interfaces
{
    public interface IAnimalRepository:IRepository<Animal>
    {
        public IEnumerable<Animal> GetAnimals(AnimalQueryFilter filter);
    }
}
