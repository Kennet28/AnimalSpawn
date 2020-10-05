using AnimalSpawn.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSpawn.Domain.Interfaces
{
    public interface IGenusRepository
    {
        Task<IEnumerable<Genus>> GetAllGenus();
        Task<Genus> GetGenus(int id);
        //Task<IEnumerable<Genus>> DeleteGenus(int id);
        Task<IEnumerable<Genus>> UpdateGenus(int id);

    }
}
