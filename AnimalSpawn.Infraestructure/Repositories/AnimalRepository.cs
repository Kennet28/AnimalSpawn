using AnimalSpawn.Domain.Entities;
using AnimalSpawn.Domain.Interfaces;
using AnimalSpawn.Domain.QueryFilters;
using AnimalSpawn.Infraestructure.Data;
using LinqKit;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace AnimalSpawn.Infraestructure.Repositories
{
    public class AnimalRepository : SQLRepository<Animal>, IAnimalRepository
    {
        private readonly AnimalSpawnContext _context;
        public AnimalRepository(AnimalSpawnContext context) : base(context)
        {
            this._context = context;
        }
        public IEnumerable<Animal> GetAnimals(AnimalQueryFilter filter)
        {
            Expression<Func<Animal, bool>> exprFinal = animal => animal.Id > 0;
            if (!string.IsNullOrEmpty(filter.Name) && !string.IsNullOrWhiteSpace(filter.Name))
            {
                Expression<Func<Animal, bool>> expr = animal => animal.Name.Contains(filter.Name);
                exprFinal = exprFinal.And(expr);
            }
            if (filter.Family.HasValue)
            {
                Expression<Func<Animal, bool>> expr = animal => animal.FamilyId == filter.Family.Value;
                exprFinal = exprFinal.And(expr);
            }
            if (filter.Specie.HasValue)
            {
                Expression<Func<Animal, bool>> expr = animal => animal.SpeciesId == filter.Specie.Value;
                exprFinal = exprFinal.And(expr);
            }
            if (filter.Genus.HasValue)
            {
                Expression<Func<Animal, bool>> expr = animal => animal.GenusId == filter.Genus.Value;
                exprFinal = exprFinal.And(expr);
            }
            if (filter.CaptureDateMax.HasValue && filter.CaptureDateMin.HasValue)
            {
                Expression<Func<Animal, bool>> expr = animal =>
                animal.CaptureDate.Value.Date >= filter.CaptureDateMin.Value.Date
                 && animal.CaptureDate.Value.Date <= filter.CaptureDateMax.Value.Date;
                exprFinal = exprFinal.And(expr);
            }
            if (!string.IsNullOrEmpty(filter.RfTag) && !string.IsNullOrWhiteSpace(filter.RfTag))
            {
                Expression<Func<RfidTag, bool>> expr = rfidTag => rfidTag.Tag == filter.RfTag;
                var animals = _context.RfidTag.Where(expr)
               .Include(x => x.IdNavigation).Select(x => x.IdNavigation);
                return animals.Where(exprFinal).AsEnumerable();
            }
            return FindByCondition(exprFinal);
        }
    }
}
