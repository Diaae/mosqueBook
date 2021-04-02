using mosquebookapi.Models.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mosquebookapi.Models.Base
{
    public abstract class LogicalRemovableEntity<Tkey> : EntityBase<Tkey>, ILogicalRemovableEntity
    {
        public bool IsDeleted { get; set ; }
    }
}
