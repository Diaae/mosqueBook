using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace mosquebookapi.Models
{
    [Table("Event")]
    public class Event
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public virtual EventType EventType { get; set; }
        public string Description { get; set; }
        public DateTime DateTime { get; set; }
        public virtual Mosque Mosque { get; set; }
        public virtual IEnumerable<EventGroup> Groups { get; set; }
       
    }
}
