
using ProductListApp.Models;

public class Program
{
    public static void Main(string[] args)
    {
        Product product1 = new Product(1, "Books", 100, 10);
        Product product2 = new Product(2, "Grocery", 1000, 10);
        Product product3 = new Product(3, "Chocolates", 3000, 10);
        Product product4 = new Product(4, "Toys", 1000, 10);


        LineItem lineitem1 = new LineItem(101, 2, product1);
        LineItem lineitem2 = new LineItem(201, 3, product2);
        LineItem lineitem3 = new LineItem(301, 6, product3);
        LineItem lineitem4 = new LineItem(401, 7, product4);

        List<LineItem> items1 = new List<LineItem>();
        items1.Add(lineitem1);
        items1.Add(lineitem2);
        List<LineItem> items2 = new List<LineItem>();
        items2.Add(lineitem3);
        items2.Add(lineitem4);

        Order order1 = new Order(1, DateTime.Now, items1);
        Order order2 = new Order(2, DateTime.Now, items2);

        List<Order> orders = new List<Order>();
        orders.Add(order1);
        orders.Add(order2);

        Customer customer = new Customer(1, "Aryan", orders);
        Console.WriteLine($"Customer Id: {customer.customerId}  \nCustomer Name: {customer.customerName} \nOrder Count: {orders.Count} ");


        Print(orders);

    }



    static void Print(List<Order> orders)
    {

        foreach (Order order in orders)
        {

            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Order Id: " + order.GetOrderId() + " \nOrder Date: " + order.GetDate());
            Console.WriteLine("\nLine Item Details");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"|{"Line ItemId",-12} | {"Product Id",-12} | {"Product Name",-15} | {"Quantity",-10} | {"Unit Price",-15} | {"Discount",-10} | {"Cost after discount",-20} | {"Total Lineitem Cost",-20} |");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------");

            foreach (LineItem lineItem in order.items)
            {

                Console.WriteLine($"|{lineItem.GetListId(),-12} | {lineItem.GetProduct().GetProductId(),-12} | {lineItem.GetProduct().GetProductName(),-15} | {lineItem.GetListQuantity(),-10} | {lineItem.GetProduct().GetProductPrice(),-15} | {lineItem.GetProduct().GetProductDiscount() + "%",-10} | {lineItem.GetProduct().CalculateDiscountedPrice(),-20} | {lineItem.CalculateLineItemCost(),-20} |");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------");

            }

            Console.WriteLine($"|{"Total Cost",-12} | {"",-12} | {"",-15} | {"",-10} | {"",-15} | {"",-10} | {"",-20} | {order.CalculateOrderPrice(),-20} |");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}



