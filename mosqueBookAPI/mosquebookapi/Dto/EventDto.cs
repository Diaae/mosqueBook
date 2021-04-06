using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mosquebookapi.Dto
{
    public class EventDto
    {
        public Guid Id { get; set; }
        public  EventTypeDto EventType { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public  MosqueDto Mosque { get; set; }
        public virtual IEnumerable<EventGroupDto> Groups { get; set; }
        public int Availability { get
            {
                var tuple = Groups.Select(g => g.MaxPlaces - g.Appointments.Count(el => el.IsActif));
                return tuple.Aggregate(0, (acc, x) => acc + x);
            }
        }
    }
}
