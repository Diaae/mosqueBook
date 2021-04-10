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
    [Index("EventId","UserId", IsUnique = true)]
    [Index(nameof(Token), IsUnique = true)]
    [Table("Appointment")]
    public partial class Appointment : EntityBase<Guid>
    {
        
        public Guid Token { get; set; }
        public bool IsActif { get; set; }
        public virtual Event Event { get; set; }
        public virtual User User { get; set; }
        public virtual EventGroup Group { get; set; }

    }
}
