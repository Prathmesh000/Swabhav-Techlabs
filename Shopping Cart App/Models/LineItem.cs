using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductListApp.Models
{
    internal class LineItem 
    {
        private int _listId;
        private int _listQuantity;
        private Product _product;

    
        public Product GetProduct() { return _product; }
        public int GetListId()
        {
            return _listId;
        }
        public void SetListId(int listId)
        {
            _listId = listId;
        }

        public int GetListQuantity()
        {
            return _listQuantity;
        }
        public void SetListQuantity(int listQuantity)
        {
            _listQuantity = listQuantity;
        }

        public LineItem(int listId, int listQuantity, Product product)
        {
            _listId = listId;
            _listQuantity = listQuantity;
            _product = product;
        }

        public double CalculateLineItemCost()
        {
            double LineItemCost = _listQuantity * _product.CalculateDiscountedPrice();
            return LineItemCost;
        }
    }
}
