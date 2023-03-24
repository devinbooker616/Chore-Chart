using BaseCamp.Chores.Core.DTOs;
using BaseCamp.Chores.Core.Entities;
using BaseCamp.Chores.Core.Interfaces;
using BaseCamp.Chores.Infrastructure.Context;

namespace BaseCamp.Chores.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly ChoreDbContext _context;
        public DepartmentRepository(ChoreDbContext context)
        {
            this._context = context;
        }

        public Department CreateDepartment(CreateDepartment newDepartment)
        {
            var department = new Department(){
                Id = Guid.NewGuid(),
                Name = newDepartment.Name
            };

            this._context.Department.Add(department);
            this._context.SaveChanges();

            return department;
        }

        public void DeleteDepartment(Guid id)
        {
           var department = this._context.Department.FirstOrDefault(x => x.Id == id);

           if(department == null)
           {
                throw new KeyNotFoundException();
           }
           else
           {
                this._context.Department.Remove(department);
                this._context.SaveChanges();
           }
        }

        public Department GetDepartment(Guid id)
        {
            return this._context.Department.FirstOrDefault(x => x.Id == id);
        }

        public List<Department> GetDepartments()
        {
            return this._context.Department.ToList();
        }
    }
}