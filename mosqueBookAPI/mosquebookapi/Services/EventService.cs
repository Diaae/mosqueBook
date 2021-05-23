using AutoMapper;
using mosquebookapi.Data.Repositories.Interfaces;
using mosquebookapi.Dto;
using mosquebookapi.Helpers;
using mosquebookapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mosquebookapi.Services
{
    public class EventService
    {
        private readonly IEventRepository _eventRepository;
        private readonly IEventTypeRepository _eventTypeRepository;
        private readonly IEventGroupRepository _eventGroupRepository;
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        public EventService(
            IEventRepository eventRepository,
            IEventTypeRepository eventTypeRepository,
            IEventGroupRepository eventGroupRepository,
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _eventRepository = eventRepository;
            this._eventTypeRepository = eventTypeRepository;
            this._eventGroupRepository = eventGroupRepository;
            _uow = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<EventDto>> ListAll()
        {
            var list = await _eventRepository.ListAll();
            return _mapper.Map<IEnumerable<EventDto>>(list);

        }

        public async Task<int> Save(EventDto eventDto)
        {
            var @event = _mapper.Map<Event>(eventDto);
            _eventRepository.Save(@event);
            return await _uow.CommitAsync();
        }

     

        public async Task<EventDto> FindById(Guid id)
        {
            var @event = await _eventRepository.FindById(id);

            return _mapper.Map<EventDto>(@event);
        }
        public  EventDto FindByEventTypeIdAndDate(Guid id,DateTime date)
        {
            var @event =  _eventRepository.FindByEventTypeIdAndDate(id,date);

            return _mapper.Map<EventDto>(@event);
        }

        public async Task Remove(Guid eventId)
        {
            var @event = await _eventRepository.FindById(eventId);
            _eventRepository.Remove(@event);
        }

        public  int GetAvaiability(EventDto eventDto)
        {
            var tuple = eventDto.Groups.Select(g => g.MaxPlaces - g.Appointments.Count());
            return  tuple.Aggregate(0,(acc,x) => acc + x);
        }

        public async Task AddEvents(int maxNumberDays)
        {
            EventType fajrEventType = await _eventTypeRepository.FindById(AppConsts.FAJR_ID);
            Mosque mosque = fajrEventType.Mosque;

            EventType dohrEventType = await _eventTypeRepository.FindById(AppConsts.DOHR_ID);
            EventType asrEventType = await _eventTypeRepository.FindById(AppConsts.ASR_ID);
            EventType maghrebEventType = await _eventTypeRepository.FindById(AppConsts.MAGHREB_ID);
            EventType ishaaEventType = await _eventTypeRepository.FindById(AppConsts.ISHAA_ID);

            for (int i = 0; i < maxNumberDays; i++)
            {
                var fajrEvent = new Event
                {
                    Id = Guid.NewGuid(),
                    EventType = fajrEventType,
                    Date = DateTime.Now.AddDays(i),
                    Description = "",
                    Mosque = mosque

                };
                var dohrDate = DateTime.Now.AddDays(i);
                var isFriday = dohrDate.DayOfWeek == DayOfWeek.Friday;
                var dohrEvent = new Event
                {
                    Id = Guid.NewGuid(),
                    EventType = dohrEventType,
                    Date = dohrDate,
                    Description = isFriday ? "Enthält Gruppen: Jumuah Gruppe 1 - Jumuah Gruppe 2" : "",
                    Mosque = mosque
                };
                var asrEvent = new Event
                {
                    Id = Guid.NewGuid(),
                    EventType = asrEventType,
                    Date = DateTime.Now.AddDays(i),
                    Description = "",
                    Mosque = mosque
                };
                var maghrebEvent = new Event
                {
                    Id = Guid.NewGuid(),
                    EventType = maghrebEventType,
                    Date = DateTime.Now.AddDays(i),
                    Description = "",
                    Mosque = mosque
                };
                var ishaaEvent = new Event
                {
                    Id = Guid.NewGuid(),
                    EventType = ishaaEventType,
                    Date = DateTime.Now.AddDays(i),
                    Description = "",
                    Mosque = mosque
                };


                //await _eventRepository.AddRange(new[] { fajrEvent, dohrEvent, asrEvent, maghrebEvent, ishaaEvent });
                //context.SaveChanges();
                var eventGroupList = new List<EventGroup>() {
                        new EventGroup
                        {
                            Id = Guid.NewGuid(),
                            MaxPlaces = 120,
                            Name = "Salat " + fajrEventType.Name,
                            Event = fajrEvent
                        },new EventGroup
                        {
                            Id = Guid.NewGuid(),
                            MaxPlaces = 120,
                            Name = "Salat " + asrEventType.Name,
                            Event = asrEvent
                        }, new EventGroup
                        {
                            Id = Guid.NewGuid(),
                            MaxPlaces = 120,
                            Name = "Salat " + maghrebEventType.Name,
                            Event = maghrebEvent
                        }, new EventGroup
                        {
                            Id = Guid.NewGuid(),
                            MaxPlaces = 120,
                            Name = "Salat " + ishaaEventType.Name,
                            Event = ishaaEvent
                        }
                    };
                if (isFriday)
                {
                    eventGroupList.AddRange(new[]{
                            new EventGroup{
                            Id = Guid.NewGuid(),
                            MaxPlaces = 120,
                            Name = "Jumuah Gruppe 1",
                            Event = dohrEvent
                        },new EventGroup{
                            Id = Guid.NewGuid(),
                            MaxPlaces = 120,
                            Name = "Jumuah Gruppe 2 " ,
                            Event = dohrEvent
                        }
                        }
                   );
                }
                else
                {
                    eventGroupList.Add(new EventGroup
                    {
                        Id = Guid.NewGuid(),
                        MaxPlaces = 120,
                        Name = "Salat " + dohrEventType.Name,
                        Event = dohrEvent
                    }
                    );
                }
                await _eventGroupRepository.AddRange(eventGroupList);
                await _uow.CommitAsync();
                //context.SaveChanges();
            }
        }
    }
}
