using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TimesheetBackend.Data;
using TimesheetBackend.Models;
using TimesheetBackend.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TimesheetBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimesheetController : ControllerBase
    {

        private readonly IDateService _dateService;
        public TimesheetController(IDateService dateService)
        {
            _dateService = dateService;
        }

        // GET: api/<TimesheetController>
        [HttpGet]
        public IEnumerable<Date> Get()
        {
            return _dateService.GetDateService();
        }

     

        // POST api/<TimesheetController>
        [HttpPost]
        public IActionResult Post([FromBody] Date date)
        {
            _dateService.PostDateService(date);
            return Ok(new { message = "Timesheet successfully created" });
        }

        // DELETE api/<TimesheetController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _dateService.DeleteDateService(id);
        }











        //// PUT api/<TimesheetController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}



        //// GET api/<TimesheetController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}
    }
}
