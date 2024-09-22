using Microsoft.AspNetCore.Mvc;
using TimesheetBackend.Models;
using TimesheetBackend.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TimesheetBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimesheetCrudController : ControllerBase
    {
        private readonly ITimesheetRepository _timesheetRepository;

        public TimesheetCrudController(ITimesheetRepository timesheetRepository)
        {
            _timesheetRepository = timesheetRepository;
        }
        // GET: api/<TimesheetCrudController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TimesheetCrudController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TimesheetCrudController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TimesheetCrudController>/5
        [HttpPut("{id}")]
        public void Put([FromBody]  Timesheet timesheet)
        {
            _timesheetRepository.UpdateTimesheet(timesheet);
        }

        // DELETE api/<TimesheetCrudController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _timesheetRepository.DeleteTimesheet(id);
        }
    }
}
