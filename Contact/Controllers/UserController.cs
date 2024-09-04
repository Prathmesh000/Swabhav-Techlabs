using ContactAppRestApi2.Data;
using ContactAppRestApi2.DTO;
using ContactAppRestApi2.Models;
using ContactAppRestApi2.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ContactAppRestApi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _userServices = new UserServices();
        private readonly ContactDbContext _dbContext = new ContactDbContext();
        
        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<UserDto> Get()
        {
            Console.WriteLine("Enter Your User Id: ");
            int id = int.Parse(Console.ReadLine());
            User user = _dbContext.Users.Where(i => i.UserId == id && i.IsAdmin == true).FirstOrDefault();

            var users = _userServices.GetUsersService();

            var userDTO = from u in users
                          where u.IsActive == true
                          select new UserDto()
                          {
                              FirstName = u.FirstName,
                              LastName = u.LastName,
                          };
        
            return userDTO;

        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] UserDto userDto)
        {
            var User = new User()
            {
                FirstName = userDto.FirstName,
                LastName = userDto.LastName,
                IsActive = true,
                IsAdmin = true,

            };
            _userServices.AddUserService(User);


        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
