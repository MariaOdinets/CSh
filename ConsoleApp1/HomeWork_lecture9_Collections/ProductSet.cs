using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_homeworks.HomeWork_lecture9_Collections
{
    public class ProductSet : Product //IEnumerable
    {
        public string productSetTitle { get; set; } = "Spring Set";

        public ProductItem item;
        public List<ProductItem> ProductItems { get; set; }
        public List<Product> ProductList { get; set; }

        public ProductSet(List<ProductItem> productItems)
        {
            ProductItems = productItems;
        }

        public ProductSet(List<Product> productList)
        {
            ProductList = productList;
        }

        public ProductSet(string productSetTitle, int price, List<Product>productList)
        {
            this.productSetTitle= productSetTitle;
            this.price= price;
            ProductList= productList;
        }

        //public override string ToString()
        //{
        //    return $"Item: {name}, price: {price}";
        //}

        public override void GetInfo()
        {
            Console.WriteLine($"{productSetTitle}, price: {price}");
        }
        public override void CheckExpirationDate()
        {
            //find max exp
        }
    }
}
