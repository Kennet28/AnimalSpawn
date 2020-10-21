using AnimalSpawn.Domain.Entities;
using AnimalSpawn.Domain.Interfaces;
using AnimalSpawn.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AnimalSpawn.Infraestructure.Repositories
{
    public class SQLRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly AnimalSpawnContext _context;
        private readonly DbSet<T> _entities;
        public SQLRepository(AnimalSpawnContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }

        public async Task Add(T entity)
        {
            if (entity == null) throw new ArgumentNullException("Entity");
            _entities.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            if (id <= 0) throw new ArgumentNullException("Entity");
            var entity = await GetById(id);
            _entities.Remove(entity);
            await _context.SaveChangesAsync();

        }

        public async Task<IEnumerable<T>> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return await _entities.Where(expression).AsNoTracking().ToListAsync();

        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _entities.AsNoTracking().ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _entities.AsNoTracking().SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task Update(T entity)
        {
            if (entity == null) throw new ArgumentNullException("Entity");
            if (entity.Id <= 0) throw new ArgumentNullException("Entity");
            _entities.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
