using System;
using System.Collections.Generic;

namespace ProductListApp.Models
{
    internal class Customer
    {
        public int customerId;
        public string customerName;
        public List<Order> orders;

      

        public Customer(int id, string name, List<Order> customerOrders)
        {
            customerId = id;
            customerName = name;
            orders = customerOrders;
          
        }
    }
}
