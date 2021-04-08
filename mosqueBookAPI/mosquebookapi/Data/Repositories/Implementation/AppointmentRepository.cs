﻿using mosquebookapi.Data.Repositories.Interfaces;
using mosquebookapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mosquebookapi.Data.Repositories.Implementation
{
    public class AppointmentRepository : GenericRepository<Appointment>,IAppointmentRepository
    {
        public AppointmentRepository(ApplicationContext applicationContext):base(applicationContext)
        {
                
        }
        public override void Add(Appointment appointment)
        {
            _context.Attach(appointment.Group);
            _context.Attach(appointment.User);
            base.Add(appointment);
        }
    }
}
