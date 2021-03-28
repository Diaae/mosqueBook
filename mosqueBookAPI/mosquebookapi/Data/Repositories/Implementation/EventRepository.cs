using mosquebookapi.Data.Repositories.Abstraction;
using mosquebookapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mosquebookapi.Data.Repositories.Implementation
{
    public class EventRepository : IEventRepository
    {

        private readonly MosqueBookContext _context;
        public EventRepository(MosqueBookContext mosqueBookContext)
        {
            _context = mosqueBookContext;
        }
        public void Delete(Guid itemId)
        {
            throw new NotImplementedException();
        }

        public Event FindById(Guid itemId)
        {
            return _context.Events.SingleOrDefault(e => e.Id == itemId);
        }

        public IEnumerable<Event> ListAll()
        {
            return _context.Events.ToList();
        }

        public void Save(Event item)
        {
            _context.Events.Add(item);
            _context.SaveChanges();
        }
    }
}
