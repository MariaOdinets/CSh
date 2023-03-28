using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_homeworks.HomeWork_lecture9_Collections
{
    internal class ProductSet
    {
        public string SetName { get; set; }
        List<Product> productList { get; set; }
        public Product Product { get; set; }
        public Product Product2 { get; set; }
        List<ProductSet> ProductSets { get; set; }

        public ProductSet(string SetName, Product Product, Product Product2)
        {
            this.SetName = SetName;
            this.Product = Product;
            this.Product2 = Product;
        }

        public override string ToString()
        {
            return $"{SetName}";
        }
        public int GetSetPrice()
        {
            return Product.productPrice + Product2.productPrice - 20;
        }
        public void CheckExpirationDate()
        {
            foreach (var item in ProductSets)
            {
               
            }
        }
    }
}
