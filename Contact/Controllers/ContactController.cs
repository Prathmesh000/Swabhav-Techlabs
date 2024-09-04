using ContactAppRestApi2.DTO;
using ContactAppRestApi2.Models;
using ContactAppRestApi2.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ContactAppRestApi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService = new ContactService();
        // GET: api/<ContactController>
        [HttpGet]
        public IEnumerable<ContactDto> Get()
        {
            var contacts = _contactService.GetContactsService();

            var contactDto = from c in contacts
                             select new ContactDto
                             {
                                 FirstName = c.FirstName,
                                 LastName = c.LastName,
                                 UserId = c.UserId,
                             };
            return contactDto;
        }

        // GET api/<ContactController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ContactController>
        [HttpPost]
        public void Post([FromBody] ContactDto contactDto)
        {
            Contact contact = new Contact()
            {
                FirstName = contactDto.FirstName,
                LastName = contactDto.LastName,
                UserId = contactDto.UserId,
                IsActive = true,
            };
            _contactService.AddContactService(contact);
        }

        // PUT api/<ContactController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ContactController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
