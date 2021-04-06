﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace mosquebookapi.Dto
{
    public class EventGroupDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public  IEnumerable<AppointmentDto> Appointments { get; set; }
        [JsonIgnore]
        public EventDto Event { get; set; }
        public int MaxPlaces { get; set; }
    }
}
