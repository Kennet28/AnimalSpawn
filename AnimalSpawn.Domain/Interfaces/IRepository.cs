using AnimalSpawn.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSpawn.Domain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task Add(T entity);
        IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression);
        IEnumerable<T> GetAll();
        void Update(T entity);
        Task<T> GetById(int id);
        Task Delete(int id);
    }

}
