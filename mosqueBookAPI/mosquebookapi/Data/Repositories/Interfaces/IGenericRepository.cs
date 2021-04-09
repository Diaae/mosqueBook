using mosquebookapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace mosquebookapi.Data.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T: class
    {
        Task<T> FindById(Guid itemId);
        Task<IEnumerable<T>> ListAll();
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        bool Exists(T entity);
        void Add(T entity);
        void Update(T entity);

        void Remove(T entity);
    }
}
