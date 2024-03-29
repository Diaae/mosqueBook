﻿using Microsoft.EntityFrameworkCore;
using mosquebookapi.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace mosquebookapi.Models
{
    [Index(nameof(Email), IsUnique = true)]
    [Table("Mosque")]
    public partial class Mosque : EntityBase<Guid>
    {
       
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public virtual IEnumerable<EventType> Events { get; set; }
    }
}
