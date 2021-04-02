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
    [Index(nameof(Email), IsUnique = true)]
    [Table("User")]
    public partial class User : EntityBase<Guid>
    {
        
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        public virtual IEnumerable<Appointment> Appointments { get; set; }
    }
}
