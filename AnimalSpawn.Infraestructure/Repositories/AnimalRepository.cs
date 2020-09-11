using System;
using System.Collections.Generic;
using System.Linq;
using AnimalSpawn.Domain.Entities;

namespace AnimalSpawn.Infraestructure.Repositories
{
    public class AnimalRepository
    {
        public IEnumerable<Animal> GetAnimals()
        {
            var animals = Enumerable.Range(1, 10).Select(x => new Animal
            {
                Name = $"animal-{x}",
                CaptureCondition = "Good",
                CaptureDate = DateTime.Now,
                Description = $"Description of animal-{x}",
                EstimatedAge = (int)Math.Truncate(DateTime.Now.Minute * 2.5),
                Gender = x % 2 == 0,
                Height = Math.Round(DateTime.Now.Minute * 1.16, 2),
                Weight = Math.Round(DateTime.Now.Minute * 4.5, 2)
            });
            return animals;
        }
    }
}