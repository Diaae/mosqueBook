using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace mosquebookapi.Models
{
    //[Index(nameof(Date), IsUnique = true)]
    //[Table("Appointment")]
    public class Appointment
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Key]
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public User User { get; set; }

    }
}
