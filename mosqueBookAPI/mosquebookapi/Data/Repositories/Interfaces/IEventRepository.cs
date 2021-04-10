using mosquebookapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mosquebookapi.Data.Repositories.Interfaces
{
    public interface IEventRepository : IGenericRepository<Event>
    {
        void Save(Event @event);
        Event FindByEventTypeIdAndDate(Guid eventTypeId, DateTime date);
    }
}
