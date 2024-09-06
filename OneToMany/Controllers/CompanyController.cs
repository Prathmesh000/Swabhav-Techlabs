using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OneToManyRestApi.Data;
using OneToManyRestApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OneToManyRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly CompanyDbContext _dbContext = new CompanyDbContext();
       

        // GET: api/<CompanyController>
        [HttpGet]
        public IEnumerable<Company> Get()
        {
            return _dbContext.Companies.Include(c => c.CompanyProducts).ToList();
        }

        // GET api/<CompanyController>/5
        [HttpGet("{id}")]
        public Company Get(int id)
        {
            return _dbContext.Companies.Include(i => i.CompanyProducts).SingleOrDefault(i => i.CompanyId == id);
        }

        // POST api/<CompanyController>
        [HttpPost]
        public void Post([FromBody] Company company)
        {
            _dbContext.Companies.Add(company);


            _dbContext.SaveChanges();
        }

        // PUT api/<CompanyController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Company company)
        {
            Company company1 = _dbContext.Companies.Find(id);
            company1.CompanyName = company.CompanyName;
            company1.CompanyAddress = company.CompanyAddress;

            _dbContext.SaveChanges();
        }

        // DELETE api/<CompanyController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Company company = _dbContext.Companies.Find(id);
            _dbContext.Remove(company);
            _dbContext.SaveChanges();
        }
    }
}
