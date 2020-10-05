using System.Threading.Tasks;
using System.Collections.Generic;
using AnimalSpawn.Domain.Entities;

namespace AnimalSpawn.Domain.Interfaces
{
    public interface IAnimalRepository
    {
         Task<IEnumerable<Animal>> GetAnimals();
        Task<Animal> GetAnimal(int id);
        Task AddAnimal(Animal animal);
        Task<bool> UpdateAnimal(Animal animal);
        Task<bool> DeleteAnimal(int id);
    }
}