using mosquebookapi.Data;
using mosquebookapi.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mosquebookapi.Services
{
    public class TemporaryAuthenticator
    {
        public ApplicationContext _context;
        public IUserRepository _userRepository;

        public TemporaryAuthenticator(ApplicationContext context, IUserRepository userRepository)
        {
            _context = context;
            _userRepository = userRepository;
        }

        public string Auth(string email,string pwd)
        {
           var user =  _userRepository.FindByEmailAndPassword(email, pwd);
            if(user != null)
            {
                return _context.TemporaryAuthenticators.FirstOrDefault().Token.ToString();
            }
            return "";
        }

        public bool ValidateToken(Guid token)
        {
            return _context.TemporaryAuthenticators.Any(tk => tk.Token == token);
        }


    }
}
