using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using AnimalSpawn.Domain.Entities;
using AnimalSpawn.Domain.Interfaces;
using AnimalSpawn.Infraestructure.Data;

namespace AnimalSpawn.Infraestructure.Repositories
{
    public class GenusRepository : IGenusRepository
    {
        private readonly AnimalSpawnContext _Context;
        public GenusRepository(AnimalSpawnContext context)
        {
            _Context = context;
        }
        //public Task<IEnumerable<Genus>> DeleteGenus(int id)
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<IEnumerable<Genus>> GetAllGenus()
        {
            return await _Context.Genus.ToListAsync();

        }

        public async Task<Genus> GetGenus(int id)
        {
            return await _Context.Genus.SingleOrDefaultAsync(Genus => Genus.Id == id) ?? new Genus();
        }

        public Task<IEnumerable<Genus>> UpdateGenus(int id)
        {
            throw new NotImplementedException();
        }
    }
}