using BaseCamp.Chores.Core.DTOs;
using BaseCamp.Chores.Core.Interfaces;
using BaseCamp.Chores.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BaseCamp.Chores.Web.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class DepartmentController : Controller
    {
        
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentController(IDepartmentRepository departmentRepository) {
            _departmentRepository = departmentRepository;
        }

        [HttpGet("/api/v1/Departments")]
        public IActionResult GetDepartments() {
            var department = this._departmentRepository.GetDepartments();
            return Ok(department);
        }

        [HttpGet]
        public IActionResult GetDepartment(Guid Id) {
            var department = this._departmentRepository.GetDepartment(Id);
            return Ok(department);
        }

        [HttpPost]
        public IActionResult CreateDepartment(CreateDepartment createDepartment)
         {
            var department = this._departmentRepository.CreateDepartment(createDepartment);
            return Ok(department);
        }

        [HttpDelete]
        public IActionResult DeleteDepartment(Guid Id) {
             this._departmentRepository.DeleteDepartment(Id);
            return NoContent();
        }
    }
}
