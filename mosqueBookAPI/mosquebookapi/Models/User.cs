using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace mosquebookapi.Models
{
    //[Index(nameof(Email), IsUnique = true)]
    //[Table("User")]
    public class User
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public IEnumerable<Appointment> Appointments { get; set; }
    }
}
