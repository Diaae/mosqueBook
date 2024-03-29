﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mosquebookapi.Dto
{
    public class AppointmentDto
    {
        public Guid Id { get; set; }
        public Guid Token { get; set; }
        public bool IsActif { get; set; }
        public EventLightDto Event { get; set; }

        public UserDto User { get; set; }

        public EventGroupDto Group { get; set; }
    }
}
