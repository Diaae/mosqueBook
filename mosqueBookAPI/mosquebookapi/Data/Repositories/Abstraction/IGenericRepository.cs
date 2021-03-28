using mosquebookapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mosquebookapi.Data.Repositories.Abstraction
{
    public interface IGenericRepository<T>
    {
        T FindById(Guid itemId);
        IEnumerable<T> ListAll();
        void Save(T item);

        void Delete(Guid itemId);
    }
}
