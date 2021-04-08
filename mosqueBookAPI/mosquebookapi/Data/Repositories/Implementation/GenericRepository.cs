using Microsoft.EntityFrameworkCore;
using mosquebookapi.Data.Repositories.Interfaces;
using mosquebookapi.Models.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace mosquebookapi.Data.Repositories.Implementation
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected ApplicationContext _context;
        private readonly DbSet<T> _dbSet;
        public GenericRepository(ApplicationContext applicationContext)
        {
            _context = applicationContext;
            _dbSet = _context.Set<T>();
        }

        public virtual void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Remove(T entity)
        {
            if (typeof(ILogicalRemovableEntity).IsAssignableFrom(typeof(T)))
            {
                ((ILogicalRemovableEntity)entity).IsDeleted = true;
                _dbSet.Update(entity);
            }
            else
            {
                _dbSet.Remove(entity);
            }
        }

        public async Task<T> FindById(Guid itemId)
        {
            return await _dbSet.FindAsync(itemId);
        }

        public async Task<IEnumerable<T>> ListAll()
        {
            return await _dbSet.ToListAsync();
        }

        public void Update(T item)
        {
            _dbSet.Update(item);
        }

        public async Task<IEnumerable<T>> Where(Expression<Func<T, bool>> expression)
        {
           return await _dbSet.Where(expression).ToListAsync();
        }

        public bool Exists(T entity)
        {
            return _dbSet.Contains(entity);
        }
    }
}
