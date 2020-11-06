using AnimalSpawn.Domain.Entities;
using AnimalSpawn.Domain.Interfaces;
using AnimalSpawn.Infraestructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSpawn.Infraestructure.Repositories
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private readonly AnimalSpawnContext _context;

        private readonly IAnimalRepository _animalRepository;
        private readonly IRepository<Country> _countryRepository;
        private readonly IRepository<Family> _familyRepository;
        private readonly IRepository<Genus> _genusRepository;
        private readonly IRepository<Photo> _photoRepository;
        private readonly IRepository<ProtectedArea> _protectedAreaRepository;
        private readonly IRepository<Researcher> _researcherRepository;
        private readonly IRepository<RfidTag> _rfifTagRepository;
        private readonly IRepository<Sighting> _sightingRepository;
        private readonly IRepository<Species> _speciesRepository;
        private readonly IRepository<UserAccount> _userAccountRepository;

        public UnitOfWork(AnimalSpawnContext context)
        {
            this._context = context;
        }


        public IAnimalRepository AnimalRepository => _animalRepository ?? new
        AnimalRepository(_context);
        public IRepository<Country> CountryRepository => _countryRepository ?? new
        SQLRepository<Country>(_context);
        public IRepository<Family> FamilyRepository => _familyRepository ?? new
        SQLRepository<Family>(_context);
        public IRepository<Genus> GenusRepository => _genusRepository ?? new
        SQLRepository<Genus>(_context);
        public IRepository<Photo> PhotoRepository => _photoRepository ?? new
        SQLRepository<Photo>(_context);
        public IRepository<ProtectedArea> ProtectedAreaRepository => _protectedAreaRepository ?? new
        SQLRepository<ProtectedArea>(_context);
        public IRepository<Researcher> ResearcherRepository => _researcherRepository ?? new
        SQLRepository<Researcher>(_context);
        public IRepository<RfidTag> RfifTagRepository => _rfifTagRepository ?? new
        SQLRepository<RfidTag>(_context);
        public IRepository<Sighting> SightingRepository => _sightingRepository ?? new
        SQLRepository<Sighting>(_context);
        public IRepository<Species> SpeciesRepository => _speciesRepository ?? new
        SQLRepository<Species>(_context);
        public IRepository<UserAccount> UserAccountRepository => _userAccountRepository ??
        new SQLRepository<UserAccount>(_context);


        public void Dispose()
        {
            if (_context == null)
                _context.Dispose();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SavechangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
