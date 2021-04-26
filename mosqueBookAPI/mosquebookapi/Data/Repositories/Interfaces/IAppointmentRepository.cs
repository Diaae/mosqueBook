using mosquebookapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mosquebookapi.Data.Repositories.Interfaces
{
    public interface IAppointmentRepository : IGenericRepository<Appointment>
    {
        Appointment FindByToken(Guid token);
        IEnumerable<Appointment> ListAllByGroupId(Guid groupId);
        Appointment FindByUserPhoneNumber(string phoneNumber);
        IEnumerable<Appointment> ListByGroupIdAndEventId(Guid groupId, Guid eventId);
        void Remove(Guid id);

    }
}
