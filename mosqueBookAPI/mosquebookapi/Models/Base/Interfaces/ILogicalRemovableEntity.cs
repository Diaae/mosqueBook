using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mosquebookapi.Models.Base.Interfaces
{
    public interface ILogicalRemovableEntity
    {
        public bool IsDeleted { get; set; }
    }
}
