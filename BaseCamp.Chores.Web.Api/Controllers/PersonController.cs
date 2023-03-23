using BaseCamp.Chores.Core.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace BaseCamp.Chores.Web.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PersonController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreatePerson(CreatePerson createPerson)
        {
            return Ok();
        }
    }
}
