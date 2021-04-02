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
    public class EventTypeService
    {
        private readonly IEventTypeRepository _eventTypeRepository;
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        public EventTypeService(
            IEventTypeRepository eventTypeRepository,
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _eventTypeRepository = eventTypeRepository;
            _uow = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<EventTypeDto>> ListAll()
        {
            var list = await _eventTypeRepository.ListAll();
            return _mapper.Map<IEnumerable<EventTypeDto>>(list);

        }

        public async Task<int> Save(EventTypeDto eventTypeDto)
        {
            var eventType = _mapper.Map<EventType>(eventTypeDto);
            if (_eventTypeRepository.Exists(eventType))
            {
                _eventTypeRepository.Update(eventType);
            }
            else
            {
                _eventTypeRepository.Add(eventType);
            }
            return await _uow.CommitAsync();
        }

        public async Task<EventTypeDto> FindById(Guid id)
        {
            var eventType = await _eventTypeRepository.FindById(id);

            return _mapper.Map<EventTypeDto>(eventType);
        }

        public async Task Remove(Guid eventTypeId)
        {
            var eventType = await _eventTypeRepository.FindById(eventTypeId);
            _eventTypeRepository.Remove(eventType);
        }
    }
}
