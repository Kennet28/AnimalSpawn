using AnimalSpawn.Domain.Entities;
using AnimalSpawn.Domain.Interfaces;
using AnimalSpawn.Domain.QueryFilters;
using AnimalSpawn.Infraestructure.Data;
using LinqKit;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AnimalSpawn.Infraestructure.Repositories
{
    public class AnimalRepository:SQLRepository<Animal>,IAnimalRepository
    {
        private readonly AnimalSpawnContext _context;
        public AnimalRepository( AnimalSpawnContext context):base(context)
        {
            _context = context;
        }

        public IEnumerable<Animal> GetAnimals(AnimalQueryFilter filter)
        {
            Expression<Func<Animal, bool>> expression = animal => animal.Id > 0;
            if(!string.IsNullOrEmpty(filter.Name) && !string.IsNullOrWhiteSpace(filter.Name))
            {
                Expression<Func<Animal, bool>> expr = animal => animal.Name.Contains(filter.Name);
                expression = expression.And(expr);
            }

            if (filter.Family.HasValue)
            {
                Expression<Func<Animal, bool>> expr = animal => animal.FamilyId == filter.Family.Value;
                expression = expression.And(expr);
            }

            if (filter.Genus.HasValue)
            {
                Expression<Func<Animal, bool>> expr = animal => animal.GenusId == filter.Genus.Value;
                expression = expression.And(expr);
            }

            if (filter.Specie.HasValue)
            {
                Expression<Func<Animal, bool>> expr = animal => animal.SpeciesId == filter.Specie.Value;
                expression = expression.And(expr);
            }

            if (filter.Specie.HasValue)
            {
                Expression<Func<Animal, bool>> expr = animal
                       => animal.CaptureDate.Value.Date >= filter.CaptureDateMin.Value.Date
                       && animal.CaptureDate.Value.Date <= filter.CaptureDateMax.Value.Date;
                expression = expression.And(expr);
            }

            if (!string.IsNullOrEmpty(filter.RfTag) && !string.IsNullOrWhiteSpace(filter.RfTag))
            {
                //Expression<Func<Animal, bool>> expr = animal => animal.RfidTag.Tag == filter.RfTag;
                Expression<Func<Animal, bool>> expr = animal => animal.RfidTag.Tag == filter.RfTag;
                expression = expression.And(expr);
            }

            return FindByCondition(expression);
        }
    }
}
