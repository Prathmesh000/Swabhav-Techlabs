using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductListApp.Models
{
    internal class Product
    {
        private int _productId;
        private string _productName;
        private double _productPrice;
        private double _productDiscount;

        public Product(int id, string name, double price, double discount)
        {
            _productId = id;
            _productName = name;
            _productPrice = price;
            _productDiscount = discount;
        }
        public int GetProductId()
        {
            return _productId;
        }
        public void SetProductId(int productId)
        {
            _productId = productId;
        }

        public string GetProductName()
        {
            return _productName;
        }
        public void SetProductName(string productName)
        {
            _productName = productName;
        }

        public double GetProductPrice()
        {
            return _productPrice;
        }
        public void SetProductPrice(double productPrice)
        {
            _productPrice = productPrice;
        }

        public double GetProductDiscount () { return _productDiscount; }
        public void SetProductDiscount(double productDiscount)
        {
            _productDiscount = productDiscount;
        }

        public double CalculateDiscountedPrice()
        {
            double discount = (_productDiscount / 100) * _productPrice;
            double discountedPrice = _productPrice - discount;
            return discountedPrice;
        }
    }
}
