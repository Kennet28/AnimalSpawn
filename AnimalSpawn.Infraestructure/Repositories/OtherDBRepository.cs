// using System;
// using System.Collections.Generic;
// using System.Threading.Tasks;
// using AnimalSpawn.Domain.Entities;
// using AnimalSpawn.Domain.Interfaces;
// using System.Linq;


// namespace AnimalSpawn.Infraestructure.Repositories {
//     public class OtherDBRepository : IAnimalRepository {
//         public async Task<IEnumerable<Animal>> GetAnimals () {
//             var animals = Enumerable.Range(1, 10).Select(x => new Animal {
//                 Name = $"animalDB2-{x}",
//                     CaptureCondition = "Good",
//                     CaptureDate = DateTime.Now,
//                     Description = $"Description of animal-{x} in other database",
//                     EstimatedAge = (int) Math.Truncate (DateTime.Now.Minute * 2.5),
//                     Gender = x % 2 == 0,
//                     Height = Math.Round (DateTime.Now.Minute * 1.25, 2),
//                     Weight = Math.Round (DateTime.Now.Minute * 0.15, 2)
//             });
//             await Task.Delay (10);
//             return animals;
//         }
//     }
// }