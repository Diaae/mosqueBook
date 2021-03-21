using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mosquebookapi.Data
{
    public class DbInitializer
    {
        internal static void Initialize(MosqueBookContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
