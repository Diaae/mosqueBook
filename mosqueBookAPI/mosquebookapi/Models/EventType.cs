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
    [Table("EventType")]
    public partial class EventType: EntityBase<Guid>
    { 
        public string Name { get; set; }
        public string Description { get; set; }
        [JsonIgnore]
        public virtual IEnumerable<Event> Events { get; set; }

    }
}
