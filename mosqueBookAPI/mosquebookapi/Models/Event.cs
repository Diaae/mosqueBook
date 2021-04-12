using mosquebookapi.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
    using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace mosquebookapi.Models
{
    [Table("Event")]
    public partial class Event : EntityBase<Guid>
    {
        
        public virtual EventType EventType { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
       
        public virtual IEnumerable<EventGroup> Groups { get; set; }
       
    }
}
