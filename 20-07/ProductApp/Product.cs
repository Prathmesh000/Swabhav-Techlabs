using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp
{
    internal class Product
    {
        private int _productId;
        private string _productName;
        private int _productPrice;
        private double _productDiscountPercentage;

        public Product(int productId, string productName, int productPrice, double productDiscountPercentage)
        {
            SetProductId(productId);
            SetProductName(productName);
            SetProductPrice(productPrice);
            SetProductDiscount(productDiscountPercentage);
        }

        public void SetProductId(int productId)
        {
            this._productId = productId;
        }
        public int GetProductId()
        {
            return this._productId;
        }

        public void SetProductName(string productName)
        {
            this._productName = productName;
        }
        public string GetProductName()
        {
            return _productName;
        }

        public void SetProductPrice(int productPrice)
        {
            this._productPrice = productPrice;
        }
        public int GetProductPrice()
        {
            return this._productPrice;
        }

        public void SetProductDiscount(double productDiscountPercentage)
        {
            this._productDiscountPercentage = productDiscountPercentage;
        }
        public double GetProductDiscount()
        {
            return this._productDiscountPercentage;
        }

        public double CostAfterDiscount()
        {
            double totalSavings = this._productPrice * this._productDiscountPercentage / 100;
            return this._productPrice - totalSavings;

        }

        public void PrintDetails()
        {
            Console.WriteLine("Product Id: " + GetProductId() + "\nProduct Name: " + GetProductName() + "\nProduct Original Price: "
                + GetProductPrice() + "\nProduct Discount percent: " + GetProductDiscount() + "%" + "\nProduct Price after Discount: " + CostAfterDiscount());
        }
    }
}
