using mosquebookapi.Data.Repositories.Interfaces;
using mosquebookapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mosquebookapi.Data.Repositories.Implementation
{
    public class EventTypeRepository : GenericRepository<EventType>,IEventTypeRepository
    {
        public EventTypeRepository(ApplicationContext applicationContext):base(applicationContext)
        {
        }

        public IEnumerable<EventType> ListAllByMosque(Guid id)
        {
            return Where(et => et.Mosque.Id == id).ToList();
        }

        public void Save(EventType eventType)
        {
            _context.Attach(eventType.Mosque);
            if (Exists(eventType))
            {
                Update(eventType);
            }
            else
            {
                Add(eventType);
            }
        }
    }
}
