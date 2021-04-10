using mosquebookapi.Data;
using mosquebookapi.Data.Repositories.Interfaces;
using mosquebookapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mosquebookapi.Data.Repositories.Implementation { 
    public class UserRepository : GenericRepository<User>,IUserRepository
    {
        public UserRepository(ApplicationContext applicationContext):base(applicationContext)
        {
        }

        public User FindByEmail(string email)
        {
            return _context.Users.SingleOrDefault(us => us.Email == email);
        }
    }
}
