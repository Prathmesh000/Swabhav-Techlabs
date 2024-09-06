using System.ComponentModel.DataAnnotations.Schema;

namespace OneToManyRestApi.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }
        public double ProductCost { get; set; }
        [ForeignKey("Company")]
        public int CompanyId { get; set; }
      

    }
}
