using mosquebookapi.Data.Repositories.Interfaces;
using mosquebookapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mosquebookapi.Data.Repositories.Implementation
{
    public class EventGroupRepository : GenericRepository<EventGroup>,IEventGroupRepository
    {
        public EventGroupRepository(ApplicationContext applicationContext):base(applicationContext)
        {
        }

        public Task AddRange(IEnumerable<EventGroup> eventGroupList)
        {
            return _context.AddRangeAsync(eventGroupList);
        }

        public void Save(EventGroup eventGroup)
        {
            _context.Attach(eventGroup.Event);
            if (Exists(eventGroup))
            {
                Update(eventGroup);
            }
            else
            {
                Add(eventGroup);
            }
        }
    }
}
