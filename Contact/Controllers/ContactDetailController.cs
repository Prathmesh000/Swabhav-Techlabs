using ContactAppRestApi2.DTO;
using ContactAppRestApi2.Models;
using ContactAppRestApi2.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ContactAppRestApi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactDetailController : ControllerBase
    {
        private readonly IContactDetailServices _contactDetailServices = new ContactDetailServices();
        // GET: api/<ContactDetailController>
        [HttpGet]
        public IEnumerable<ContactDetailDto> Get()
        {
            var contactDetails = _contactDetailServices.GetContactDetailService();
            var contactDetailDto = from c in contactDetails
                                   select new ContactDetailDto
                                   {
                                       Type = c.Type,
                                       Value = c.Value,
                                       ContactId = c.ContactId,
                                   };
            return contactDetailDto;
        }

        // GET api/<ContactDetailController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ContactDetailController>
        [HttpPost]
        public void Post([FromBody] ContactDetailDto contactDetailDto)
        {
            ContactDetail contactDetail = new ContactDetail()
            {
                Type = contactDetailDto.Type,
                Value = contactDetailDto.Value,
                ContactId = contactDetailDto.ContactId,
            };

            _contactDetailServices.AddContactDetailService(contactDetail);
        }

        // PUT api/<ContactDetailController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ContactDetailController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
