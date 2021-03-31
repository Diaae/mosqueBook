using mosquebookapi.Data.Repositories.Abstraction;
using mosquebookapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mosquebookapi.Data.Repositories.Implementation
{
    public class EventTypeRepository : IEventTypeRepository
    {


        private readonly MosqueBookContext _context;
        public EventTypeRepository(MosqueBookContext mosqueBookContext)
        {
            _context = mosqueBookContext;
        }
        public void Delete(Guid itemId)
        {
            var eventTypes = _context.EventTypes.Find(itemId);

            _context.EventTypes.Remove(eventTypes);

            _context.SaveChanges();
        }

        public EventType FindById(Guid itemId)
        {
            return _context.EventTypes.SingleOrDefault(e => e.Id == itemId);
        }

        public IEnumerable<EventType> ListAll()
        {
            return _context.EventTypes.ToList();
        }

        public void Save(EventType item)
        {
            _context.EventTypes.Add(item);
            _context.SaveChanges();
        }
    }
}
