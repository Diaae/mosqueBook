using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mosquebookapi.Dto
{
    public class AppointmentDto
    {
        public Guid Id { get; set; }
        public Guid Token { get; set; }
        public bool IsActif { get; set; }
        public DateTime Date { get; set; }
    }
}
