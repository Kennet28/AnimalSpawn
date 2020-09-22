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
        public async Task<IEnumerable<Animal>> GetAnimals()
        {
            
            return await _Context.Animal.ToListAsync();
        }
        public async Task<IEnumerable<Genus>> GetGenus()
        {
            
            return await _Context.Genus.ToListAsync();
        }
    }
}