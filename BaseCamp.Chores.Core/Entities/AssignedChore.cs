using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseCamp.Chores.Core.Entities
{
    public class AssignedChore
    {
        [Key]
        public Guid Id { get; set; }
        public bool IsDone { get; set; }

        public Guid PersonId { get; set; }

        public Guid ChoreId { get; set; }

        public DateTime TimeAssigned { get; set; }

    }
}
