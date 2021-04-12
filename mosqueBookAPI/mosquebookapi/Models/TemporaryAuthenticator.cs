using mosquebookapi.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mosquebookapi.Models
{

    /// <summary>
    /// To do delete it asap
    /// </summary>
    public class TemporaryAuthenticator : EntityBase<int>
    {
        public Guid Token { get; set; }
    }
}
