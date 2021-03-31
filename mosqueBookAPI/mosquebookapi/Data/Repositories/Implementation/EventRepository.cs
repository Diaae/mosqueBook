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
            var @event = _context.Events.Find(itemId);

            _context.Events.Remove(@event);

            _context.SaveChanges();
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
            _context.Attach(item.Mosque);
            _context.Attach(item.EventType);
            _context.Events.Add(item);
            _context.SaveChanges();
        }
    }
}
