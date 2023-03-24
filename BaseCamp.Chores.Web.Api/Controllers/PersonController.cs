using BaseCamp.Chores.Core.DTOs;
using BaseCamp.Chores.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BaseCamp.Chores.Web.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IPersonRepository _personRepository;
        public PersonController(IPersonRepository personRepository) {
            _personRepository = personRepository;
        }

        [HttpGet("/api/v1/Persons")]
        public IActionResult GetPersons() {
            // var person = this._personRepository.GetPersons();
            // return Ok(person);
            return Ok();
        }

        [HttpGet]
        public IActionResult GetPerson(Guid Id) {
            var person = this._personRepository.GetPerson(Id);
            return Ok(person);
        }

        [HttpPost]
        public IActionResult CreatePerson(CreatePerson createPerson)
        {   
            // var person = this._personRepository.CreatePerson(createPerson);
            // return Ok(person);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeletePerson(Guid Id) {
            // this._personRepository.DeleteChore(Id);
            return NoContent();
        }
    }
}
