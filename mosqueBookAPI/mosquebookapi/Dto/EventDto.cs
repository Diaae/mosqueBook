using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mosquebookapi.Dto
{
    public class EventDto
    {
        public Guid Id { get; set; }
        public  string EventType { get; set; }
        public string Description { get; set; }
        public DateTime DateTime { get; set; }
        public  Guid MosqueId { get; set; }
        public virtual IEnumerable<string> Groups { get; set; }
    }
}
