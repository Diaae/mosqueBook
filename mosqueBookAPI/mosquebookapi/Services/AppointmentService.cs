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
    public class AppointmentService
    {
        private readonly IUserRepository _userRepository;
        private readonly IEventGroupRepository _eventGroupRepository;
        private readonly IEventRepository _eventRepository;
        private readonly IAppointmentRepository _appointmentRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AppointmentService(
            IUserRepository userRepository,
            IEventGroupRepository eventGroupRepository,
            IEventRepository eventRepository,
            IAppointmentRepository appointmentRepository,
            IUnitOfWork unitOfWork,
            IMapper mapper
            )
        {
            _userRepository = userRepository;
            _eventGroupRepository = eventGroupRepository;
            _eventRepository = eventRepository;
            _appointmentRepository = appointmentRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        internal IEnumerable<AppointmentDto> ListByGroupAndEvent(Guid groupId, Guid eventId)
        {
            var appointments = _appointmentRepository.ListByGroupIdAndEventId(groupId, eventId);

            return _mapper.Map<IEnumerable<AppointmentDto>>(appointments);
        }

        public async Task<int> BookAppointment(AppointmentDto appointmentDto)
        {
            var appointment = _mapper.Map<Appointment>(appointmentDto);
            var @event = await _eventRepository.FindById(appointment.Event.Id);
            if(@event == null)
            {
                return 0;
            }
            var user = _userRepository.FindByPhoneNumber(appointment.User.PhoneNumber);
            if(user == null)
            {
                appointment.User.Email = string.IsNullOrEmpty(appointment.User.Email) ? null : appointment.User.Email;
                _userRepository.Add(appointment.User);
               await _unitOfWork.CommitAsync();
            }
            else
            {
                appointment.User = user;
            }
            appointment.Token = Guid.NewGuid();
            appointment.IsActif = true;
            appointment.Event = @event;
            _appointmentRepository.Update(appointment);

            return await _unitOfWork.CommitAsync();

        }

        public AppointmentDto FindByUserPhoneNumber(string phoneNumber)
        {
            var appointment = _appointmentRepository.FindByUserPhoneNumber(phoneNumber);
            return _mapper.Map<AppointmentDto>(appointment);
        }

        public AppointmentDto FindByToken(Guid token)
        {
            var appointment= _appointmentRepository.FindByToken(token);
            return _mapper.Map<AppointmentDto>(appointment);
        }

        public IEnumerable<AppointmentDto> ListAllByGroupId(Guid groupId)
        {

            var appointments = _appointmentRepository.ListAllByGroupId(groupId);

            return _mapper.Map<IEnumerable<AppointmentDto>>(appointments);

        }
    }
}
