using System;
using System.Collections.Generic;
using System.Linq;
using AnimalSpawn.Domain.Entities;
using System.Threading.Tasks;
using AnimalSpawn.Domain.Interfaces;
using AnimalSpawn.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AnimalSpawn.Infraestructure.Repositories
{
    public class AnimalRepository:IAnimalRepository
    {
        private readonly AnimalSpawnContext _Context;
        public AnimalRepository(AnimalSpawnContext context)
        {
            _Context = context;
        }

        public async Task AddAnimal(Animal animal)
        {
            _Context.Animal.Add(animal);
            await _Context.SaveChangesAsync();
        }

        public async Task<bool> DeleteAnimal(int id)
        {
            var current = await GetAnimal(id);
            _Context.Animal.Remove(current);
            var rowsDelete = await _Context.SaveChangesAsync();
            return rowsDelete > 0;
        }

        public async Task<Animal> GetAnimal(int id)
        {
            return await _Context.Animal.SingleOrDefaultAsync(animal => animal.Id == id) ?? new Animal();

        }

        public async Task<IEnumerable<Animal>> GetAnimals()
        {
            
            return await _Context.Animal.ToListAsync();
        }

        public async Task<bool> UpdateAnimal(Animal animal)
        {
            var current = await GetAnimal(animal.Id);
            current.GenusId = animal.GenusId;
            current.FamilyId = animal.FamilyId;
            current.Description = animal.Description;
            current.EstimatedAge = animal.EstimatedAge;
            current.Gender = animal.Gender;
            current.Height = animal.Height;
            current.Name = animal.Name;
            current.Photo = animal.Photo;
            current.SpeciesId = animal.SpeciesId;
            var rowsUpdate = await _Context.SaveChangesAsync();
            return rowsUpdate > 0;
        }
    }
}
