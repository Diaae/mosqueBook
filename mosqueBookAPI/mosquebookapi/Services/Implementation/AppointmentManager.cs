using mosquebookapi.Dto;
using mosquebookapi.Models;
using mosquebookapi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mosquebookapi.Services.Implementation
{
    public class AppointmentManager : IAppointmentManager
    {
        private readonly IAppointmentRepository _appointmentRepository;
        private readonly IUserRepository _userRepository;
        public AppointmentManager(IAppointmentRepository appointmentRepository,IUserRepository userRepository)
        {
            _appointmentRepository = appointmentRepository;
            _userRepository = userRepository;
        }
        public void CreateAppointment(UserAppointmentDto userAppointmentDto)
        {
            var user = new User
            {
                Id = userAppointmentDto.User.Id,
                FirstName = userAppointmentDto.User.FirstName,
                LastName = userAppointmentDto.User.LastName,
                Email = userAppointmentDto.User.Email
            };

           
            _userRepository.Save(user);

            var appointment = new Appointment
            {
                Id = userAppointmentDto.Appointement.Id,
                Date = userAppointmentDto.Appointement.Date,
                User = user
            };
            _appointmentRepository.Save(appointment);
        }

        public UserAppointmentDto GetAppointment(Guid appointmentId)
        {
            var appointment = _appointmentRepository.FindById(appointmentId);

            return new UserAppointmentDto
            {
                Appointement = new AppointmentDto
                {
                    Date = appointment.Date,
                    Id = appointment.Id
                },
                User = new UserDto
                {
                    Id = appointment.User.Id,
                    FirstName = appointment.User.FirstName,
                    LastName = appointment.User.LastName,
                    Email = appointment.User.Email
                }


            };
        }
    }
}
