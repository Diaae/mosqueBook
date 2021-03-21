using mosquebookapi.Data;
using mosquebookapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mosquebookapi.Repositories { 
    public class UserRepository : IUserRepository
    {
        private readonly MosqueBookContext _context;
        public UserRepository(MosqueBookContext mosqueBookContext)
        {
            _context = mosqueBookContext;
        }

        public void Delete(Guid itemId)
        {
            throw new NotImplementedException();
        }

        public User FindById(Guid itemId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> ListAll()
        {
            throw new NotImplementedException();
        }

        public void Save(User item)
        {
            _context.Users.Add(item);
            _context.SaveChanges();
            
        }
    }
}
