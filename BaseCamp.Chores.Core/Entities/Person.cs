using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseCamp.Chores.Core.Entities
{
    public class Person
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Guid DepartmentId { get; set; }

        public Department Department { get; set; }

        public List<AssignedChore> Chores { get; set; }
    }
}
