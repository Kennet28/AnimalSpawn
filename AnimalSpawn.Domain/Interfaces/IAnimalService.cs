using AnimalSpawn.Domain.Entities;
using AnimalSpawn.Domain.QueryFilters;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AnimalSpawn.Domain.Interfaces
{
    public interface IAnimalService
    {
        Task AddAnimal(Animal animal);
        Task DeleteAnimal(int id);
        IEnumerable<Animal> GetAnimals(AnimalQueryFilter filter);
        Task<Animal> GetAnimal(int id);
        void UpdateAnimal(Animal animal);
    }
}
