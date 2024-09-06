namespace OneToManyRestApi.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyOwner { get; set; }
        public string CompanyAddress { get; set; }

        public List<Product> CompanyProducts { get; set; }
    }
}
