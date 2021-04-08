using System;
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
        [JsonIgnore]
        public  IEnumerable<AppointmentDto> Appointments { get; set; }
        [JsonIgnore]
        public EventDto Event { get; set; }
        public int MaxPlaces { get; set; }
        public int Availability
        {
            get
            {
                return MaxPlaces - Appointments.Count(el => el.IsActif);
            }
        }
    }
}
