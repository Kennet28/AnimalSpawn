using System.Threading.Tasks;
using System.Collections.Generic;
using AnimalSpawn.Domain.Entities;

namespace AnimalSpawn.Domain.Interfaces
{
    public interface IAnimalRepository
    {
         Task<IEnumerable<Animal>> GetAnimals();
    }
}