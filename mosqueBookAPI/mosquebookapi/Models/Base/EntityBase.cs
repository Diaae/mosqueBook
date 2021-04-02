using mosquebookapi.Models.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace mosquebookapi.Models.Base
{
    public abstract class EntityBase<TKey> : IEntityBase<TKey>
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public TKey Id { get; set; }
    }
}
