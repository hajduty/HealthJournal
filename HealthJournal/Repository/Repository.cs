using HealthJournal.Data;
using HealthJournal.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HealthJournal.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly AppDbContext _dbContext;
        protected readonly DbSet<T> _dbSet;

        public Repository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }

        public T Create(T entity)
        {
            _dbSet.Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public T? Get(int id)
        {
            return _dbSet.Find(id);
        }

        public T Update(int id, T entity)
        {
            var existingEntity = Get(id);
            if (existingEntity != null)
            {
                _dbContext.Entry(existingEntity).CurrentValues.SetValues(entity);
                _dbContext.SaveChanges();
            }
            return existingEntity!;
        }

        public bool Delete(int id)
        {
            var entity = Get(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
