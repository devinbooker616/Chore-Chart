using BaseCamp.Chores.Core.DTOs;
using BaseCamp.Chores.Core.Entities;
using BaseCamp.Chores.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BaseCamp.Chores.Web.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ChoreController : ControllerBase
    {
        private readonly IChoreRepository _choreRepository;
        public ChoreController(IChoreRepository choreRepository)
        {
            _choreRepository= choreRepository;
        }


        [HttpGet("/api/v1/Chores")]
        public IActionResult GetChores()
        {
            var chores = this._choreRepository.GetChores();
            return Ok(chores);
        }

        [HttpGet]
        public IActionResult GetChore(Guid Id)
        {
            var chore = this._choreRepository.GetChore(Id);
            return Ok(chore);
        }


        [HttpPost]
        public IActionResult CreateChore(CreateChore createChore)
        {
            var chore = this._choreRepository.CreateChore(createChore);
            return Ok(chore);
        }


        [HttpDelete]
        public IActionResult DeleteChore(Guid Id)
        {
            this._choreRepository.DeleteChore(Id);
            return NoContent();
        }
    }
}
