﻿using mosquebookapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mosquebookapi.Data.Repositories.Interfaces
{
    public interface IEventTypeRepository : IGenericRepository<EventType>
    {
        IEnumerable<EventType> ListAllByMosque(Guid id);
        void Save(EventType eventType);
    }
}
