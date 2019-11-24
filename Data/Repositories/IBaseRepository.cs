using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();

        Task<T> GetById(int id);

        Task Create(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}