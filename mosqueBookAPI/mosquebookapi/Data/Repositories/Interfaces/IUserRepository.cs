﻿using mosquebookapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mosquebookapi.Data.Repositories.Interfaces
{
    public interface IUserRepository : IGenericRepository<User>
    {
        User FindByEmail(string email);
    }
}
