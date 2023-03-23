using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseCamp.Chores.Core.DTOs
{
    public class CreatePerson
    {
        public string Name { get; set; }

        public Guid DepartmentId { get; set; }
    }
}
