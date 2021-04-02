using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mosquebookapi.Dto
{
    public class EventGroupDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public  IEnumerable<AppointmentDto> Appointments { get; set; }
        public int MaxPlaces { get; set; }
    }
}
