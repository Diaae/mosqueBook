using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mosquebookapi.Dto
{
    public class UserAppointmentDto
    {
        public UserDto User { get; set; }
        public AppointmentDto Appointement { get; set; }
    }
}
