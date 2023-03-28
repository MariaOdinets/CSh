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
    }
}
