using mosquebookapi.Data.Repositories.Abstraction;
using mosquebookapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mosquebookapi.Data.Repositories
{
    public class MosqueRepository : IMosqueRepository
    {

        private readonly MosqueBookContext _context;
        public MosqueRepository(MosqueBookContext mosqueBookContext)
        {
            _context = mosqueBookContext;
        }
        public void Delete(Guid itemId)
        {
            var mosque = _context.Mosques.Find(itemId);

            _context.Mosques.Remove(mosque);

            _context.SaveChanges();
        }

        public Mosque FindById(Guid itemId)
        {
            return _context.Mosques.SingleOrDefault(m => m.Id == itemId);
        }

        public IEnumerable<Mosque> ListAll()
        {
           return  _context.Mosques.ToList();
        }

        public void Save(Mosque item)
        {
            _context.Mosques.Add(item);
            _context.SaveChanges();
            
        }
    }
}
