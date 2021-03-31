using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace mosquebookapi.Models
{
    [Table("Group")]
    public class EventGroup
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual IEnumerable<Appointment> Appointments { get; set; }
        public virtual Event Event { get; set; }
        public int MaxPlaces { get; set; }
    }
}
