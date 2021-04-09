using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mosquebookapi.Dto
{
    public class EventLightDto
    {
        public Guid Id { get; set; }
        public EventTypeDto EventType { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
