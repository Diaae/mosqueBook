﻿using mosquebookapi.Data.Repositories.Interfaces;
using mosquebookapi.Dto;
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

        public Task AddRange(IEnumerable<Event> events)
        {
            return _context.AddRangeAsync(events);
        }

        public Event FindByEventTypeIdAndDate(Guid eventTypeId, DateTime date)
        {
           return _context.Events.SingleOrDefault(ev => ev.EventType.Id == eventTypeId && ev.Date.Day == date.Day && ev.Date.Month == date.Month && ev.Date.Year == date.Year);
        }

     

        public void Save(Event @event)
        {
            _context.Attach(@event.EventType);
           
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
