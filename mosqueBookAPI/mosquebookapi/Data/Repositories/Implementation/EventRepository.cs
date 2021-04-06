using mosquebookapi.Data.Repositories.Interfaces;
using mosquebookapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mosquebookapi.Data.Repositories.Implementation
{
    public class EventRepository : GenericRepository<Event>, IEventRepository
    {

        public EventRepository(ApplicationContext applicationContext) : base(applicationContext)
        {
        }

        public void Save(Event @event)
        {
            _context.Attach(@event.EventType);
            _context.Attach(@event.Mosque);
            if (Exists(@event))
            {
                Update(@event);
            }
            else
            {
                Add(@event);
            }
        }
    }
}
