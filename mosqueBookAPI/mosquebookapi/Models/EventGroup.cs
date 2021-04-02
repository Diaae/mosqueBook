using Microsoft.EntityFrameworkCore;
using mosquebookapi.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace mosquebookapi.Models
{
    [Table("Group")]
    public partial class EventGroup:EntityBase<Guid>
    {
        
        [Required]
        public string Name { get; set; }
        public virtual IEnumerable<Appointment> Appointments { get; set; }
        public virtual Event Event { get; set; }
        public int MaxPlaces { get; set; }
    }
}
