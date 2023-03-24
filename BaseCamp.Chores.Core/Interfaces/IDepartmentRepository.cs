using BaseCamp.Chores.Core.DTOs;
using BaseCamp.Chores.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseCamp.Chores.Core.Interfaces
{
    public interface IDepartmentRepository
    {
        void DeleteDepartment(Guid id);
        Department CreateDepartment(CreateDepartment newDepartment);
        Department GetDepartment(Guid id);

        List<Department> GetDepartments();
    }
}
