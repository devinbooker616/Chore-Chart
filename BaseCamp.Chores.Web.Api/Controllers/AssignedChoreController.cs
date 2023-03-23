using BaseCamp.Chores.Core.DTOs;
using BaseCamp.Chores.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BaseCamp.Chores.Web.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class AssignedChoreController : ControllerBase
    { 
        private readonly IChoreRepository _choreRepository;
        public AssignedChoreController(IChoreRepository choreRepository)
        {
            _choreRepository= choreRepository;
        }


        //This Should return a list of all assigned chores for a particular day
        [HttpGet("")]
        public IActionResult GetAllAsignedChores(DateTime choreDate)
        {
            return new OkResult();
        }

        //This Should return a persons assigned chores on a particular day
        [HttpGet("{id}")]
        public IActionResult GetAsignedChores(Guid Id)
        {
            return new OkResult();
        }
    }
}
