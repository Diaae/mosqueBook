using AutoMapper;
using mosquebookapi.Data.Repositories.Interfaces;
using mosquebookapi.Dto;
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
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        public EventService(
            IEventRepository eventRepository,
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _eventRepository = eventRepository;
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

    }
}
