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
      
    }
}
