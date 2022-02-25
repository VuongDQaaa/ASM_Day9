using ASM_Day9.DTO;
using ASM_Day9.Entities;
using ASM_Day9.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ASM_Day9.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private IPersonService _service;
        public PersonController(IPersonService service)
        {
            _service = service;
        }

        [HttpPost]
        public void AddPerson([FromBody] PersonDTO person)
        {
            _service.AddPerson(person);
        }

        [HttpDelete("delete")]
        public void DeletePerson(int id)
        {
            _service.DeletePerson(id);
        }

        [HttpPut("update")]
        public void UpdatePerson([FromBody] Person person)
        {
            _service.UpdatePerson(person);
        }

        [HttpPost("filter")]
        public List<Person> Filter([FromBody] FilterPersonDTO filter)
        {
            return _service.Filter(filter);
        }
    }
}