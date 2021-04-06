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
    public class EventGroupService
    {
        private readonly IEventGroupRepository _eventGroupRepository;
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        public EventGroupService(
            IEventGroupRepository eventRepository,
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _eventGroupRepository = eventRepository;
            _uow = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<EventGroupDto>> ListAll()
        {
            var list = await _eventGroupRepository.ListAll();
            return _mapper.Map<IEnumerable<EventGroupDto>>(list);

        }

        public async Task<int> Save(EventGroupDto eventGroupDto)
        {
            var eventGroup = _mapper.Map<EventGroup>(eventGroupDto);
            _eventGroupRepository.Save(eventGroup);
            return await _uow.CommitAsync();
        }

        public async Task<EventGroupDto> FindById(Guid id)
        {
            var eventGroup = await _eventGroupRepository.FindById(id);

            return _mapper.Map<EventGroupDto>(eventGroup);
        }

        public async Task Remove(Guid eventGroupId)
        {
            var eventGroup = await _eventGroupRepository.FindById(eventGroupId);
            _eventGroupRepository.Remove(eventGroup);
        }

    }
}
