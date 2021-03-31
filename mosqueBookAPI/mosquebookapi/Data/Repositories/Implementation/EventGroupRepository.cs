using mosquebookapi.Data.Repositories.Abstraction;
using mosquebookapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mosquebookapi.Data.Repositories.Implementation
{
    public class EventGroupRepository : IEventGroupRepository
    {
        private readonly MosqueBookContext _context;
        public EventGroupRepository(MosqueBookContext mosqueBookContext)
        {
            _context = mosqueBookContext;
        }
        public void Delete(Guid itemId)
        {
            var eventGroups = _context.EventGroups.Find(itemId);

            _context.EventGroups.Remove(eventGroups);

            _context.SaveChanges();
        }

        public EventGroup FindById(Guid itemId)
        {
            return _context.EventGroups.SingleOrDefault(e => e.Id == itemId);
        }

        public IEnumerable<EventGroup> ListAll()
        {
            return _context.EventGroups.ToList();
        }

        public void Save(EventGroup item)
        {
            _context.EventGroups.Add(item);
            _context.SaveChanges();
        }
    }
}
