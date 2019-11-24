using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    internal class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected BlogDBContext _dBContext;
        protected DbSet<T> _entities;

        public BaseRepository(BlogDBContext blogDBContext)
        {
            _dBContext = blogDBContext;
            _entities = _dBContext.Set<T>();
        }

        public async Task Create(T entity)
        {
            await _entities.AddAsync(entity);
        }

        public void Delete(T entity)
        {
            _entities.Remove(entity);
        }

        public IQueryable<T> GetAll()
        {
            return _entities.AsQueryable();
        }

        public async Task<T> GetById(int id)
        {
            return await _entities.FindAsync(id);
        }

        public void Update(T entity)
        {
            entity.Updated = DateTime.Now;
            _entities.Update(entity);
        }
    }
}