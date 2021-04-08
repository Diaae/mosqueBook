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
        private readonly IAppointmentRepository _appointmentRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AppointmentService(
            IUserRepository userRepository,
            IEventGroupRepository eventGroupRepository,
            IAppointmentRepository appointmentRepository,
            IUnitOfWork unitOfWork,
            IMapper mapper
            )
        {
            _userRepository = userRepository;
            _eventGroupRepository = eventGroupRepository;
            _appointmentRepository = appointmentRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public Task<int> BookAppointment(AppointmentDto appointmentDto)
        {
            var appointment = _mapper.Map<Appointment>(appointmentDto);
            var user = _userRepository.FindByEmail(appointment.User.Email);
            if(user == null)
            {
                _userRepository.Add(appointment.User);
                 _unitOfWork.CommitAsync();


            }
            appointment.Token = Guid.NewGuid();
            appointment.IsActif = true;
            _appointmentRepository.Add(appointment);

            return _unitOfWork.CommitAsync();

        }
    }
}
