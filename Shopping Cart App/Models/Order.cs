using System;
using System.Collections.Generic;

namespace ProductListApp.Models
{
    internal class Order
    {
        private int _orderId;
        private DateTime _date;
        public List<LineItem> items;

     

        public Order(int orderId, DateTime date, List<LineItem> item)
        {
            _orderId = orderId;
            _date = date; 
            items = item;
            
        }

        public int GetOrderId() { return _orderId; }
        public void SetOrderId(int id) { _orderId = id; }
        public DateTime GetDate() { return _date; }
        public void SetDate(DateTime date) { _date = date; }

        public List<LineItem> GetItems() { return items; }

        public double CalculateOrderPrice()
        {
            double totalPrice = 0;
            foreach (LineItem item in items)
            {
                totalPrice += item.CalculateLineItemCost(); 
            }

            return totalPrice;
        }
    }
}
