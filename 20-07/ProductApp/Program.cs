using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(1, "Clothing Brand", 1000, 10);
            Product product2 = new Product(2, "Sports Accessories", 4000, 30);

            product1.PrintDetails();
            Console.WriteLine();
            product2.PrintDetails();
           
            
        }
    }
}
