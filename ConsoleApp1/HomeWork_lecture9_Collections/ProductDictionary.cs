using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_homeworks.HomeWork_lecture9_Collections
{
    public class ProductDictionary
    {
        static Dictionary<string, int> productDictionary = new Dictionary<string, int>()
        {
               {"Pringles",150 },
               {"Cheesecake", 200 },
               {"Cookies", 140 },
               {"Lemon Pie", 210 },
               {"Coke", 110 }
        };

        public static void PrintNameAndQuantity()
        {
            foreach (var product in productDictionary)
            {
                Console.WriteLine($"Name {product.Key}, quantity {product.Value}");
            }
        }

        public static void PrintQuantity()
        {
            foreach (var product in productDictionary)
            {
                Console.WriteLine($"Quantity {product.Value}");
            }
        }

        public static void DictionaryToList()
        {
            List<string> names = productDictionary.Keys.ToList();
            List<int> quantities = productDictionary.Values.ToList();

            foreach (var product in names)
            {
                Console.WriteLine(product);
            }

            foreach (var quantity in quantities)
            {
                Console.WriteLine(quantity);
            }
        }
        public static void ListToDictionary()
        {
            List<Product> productList = new List<Product>()
            {
                new Product("Banana milk", 540, new DateTime(2022, 11, 12), new DateTime(2023, 06, 12)),
                new Product("Gouda", 300, new DateTime(2023, 01, 25), new DateTime(2023, 07, 24)),
                new Product("Sour cream", 350, new DateTime(2022, 11, 25), new DateTime(2023, 04, 02))
            };

            Dictionary<string, int> productDictionary = productList.ToDictionary(x => x.ProductName, x => x.ProductPrice);

            foreach (var item in productDictionary)
            {
                Console.WriteLine(item);
            }
        }
    }
}