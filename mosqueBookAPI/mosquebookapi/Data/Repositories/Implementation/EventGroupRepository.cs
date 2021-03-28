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
        public void Delete(Guid itemId)
        {
            throw new NotImplementedException();
        }

        public EventGroup FindById(Guid itemId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EventGroup> ListAll()
        {
            throw new NotImplementedException();
        }

        public void Save(EventGroup item)
        {
            throw new NotImplementedException();
        }
    }
}
