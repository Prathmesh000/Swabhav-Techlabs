using Microsoft.AspNetCore.Mvc;
using OneToManyRestApi.Data;
using OneToManyRestApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OneToManyRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly CompanyDbContext _dbContext = new CompanyDbContext();

        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _dbContext.Products.ToList();
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return _dbContext.Products.FirstOrDefault(p => p.ProductId == id);
        }

        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] Product product)
        {
            _dbContext.Products.Add(product);   
            _dbContext.SaveChanges();
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Product product)
        {
            var product1 = _dbContext.Products.FirstOrDefault(p => p.ProductId == id);
            product1.ProductName = product.ProductName;
            product1.ProductCost = product.ProductCost;
            product1.ProductQuantity = product.ProductQuantity;

            _dbContext.SaveChanges();
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var product = _dbContext.Products.Find(id);
            _dbContext.Products.Remove(product);
            _dbContext.SaveChanges();
        }
    }
}
