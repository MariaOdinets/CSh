using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_homeworks.HomeWork_lecture9_Collections
{
    internal class ProductBatch
    {
        public string BatchName { get; set; }
        public int ProductQuantity { get; set; }
        Product Product { get; set; }

        public ProductBatch(string BatchName, Product Product, int ProductQuantity)
        {
            this.BatchName = BatchName;
            this.Product = Product;
            this.ProductQuantity = ProductQuantity;
        }

        public override string ToString()
        {
            return $"{BatchName}";
        }

        public int GetBatchPrice()
        {
            return Product.ProductPrice * ProductQuantity;
        }

        public void CheckExpirationDate()
        {
            Product.CheckExpirationDate();
        }
    }
}