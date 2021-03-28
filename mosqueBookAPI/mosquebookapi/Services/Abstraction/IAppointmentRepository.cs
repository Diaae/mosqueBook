using mosquebookapi.Dto;
using mosquebookapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mosquebookapi.Services.Abstraction
{
    public interface IAppointmentManager
    {

        void CreateAppointment(UserAppointmentDto userAppointmentDto);
        UserAppointmentDto GetAppointment(Guid appointmentId);
    }
}
