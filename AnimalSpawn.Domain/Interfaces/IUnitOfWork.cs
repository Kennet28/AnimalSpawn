using AnimalSpawn.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSpawn.Domain.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {
        public IAnimalRepository AnimalRepository { get; }
        public IRepository<Country> CountryRepository { get; }
        public IRepository<Family> FamilyRepository { get; }
        public IRepository<Genus> GenusRepository { get; }
        public IRepository<Photo> PhotoRepository { get; }
        public IRepository<ProtectedArea> ProtectedAreaRepository { get; }
        public IRepository<Researcher> ResearcherRepository { get; }
        public IRepository<RfidTag> RfifTagRepository { get; }
        public IRepository<Sighting> SightingRepository { get; }
        public IRepository<Species> SpeciesRepository { get; }
        public IRepository<UserAccount> UserAccountRepository { get; }

        void SaveChanges();
        Task SavechangesAsync();
    }
}
