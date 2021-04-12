using mosquebookapi.Data.Repositories.Interfaces;
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

        public Appointment FindByToken(Guid token)
        {
            return _context.Appointments.SingleOrDefault(a => a.Token == token);
        }

        public Appointment FindByUserPhoneNumber(string phoneNumber)
        {
            return _context.Appointments.SingleOrDefault(ap => ap.User.PhoneNumber == phoneNumber);
        }

        public IEnumerable<Appointment> ListAllByGroupId(Guid groupId)
        {
           return Where(a => a.Group.Id == groupId).Distinct().ToList();
        }

        public IEnumerable<Appointment> ListByGroupIdAndEventId(Guid groupId, Guid eventId)
        {
            return Where(a => a.Group.Id == groupId && a.Event.Id == eventId).Distinct().ToList();
        }

        public override void Update(Appointment appointment)
        {
            _context.Attach(appointment.Group);
            _context.Attach(appointment.User);
            base.Update(appointment);
        }
    }
}
