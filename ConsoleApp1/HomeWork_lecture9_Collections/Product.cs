using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_homeworks.HomeWork_lecture9_Collections
{/// <summary>
 /// Задание 1
    //Полную структуру классов и их взаимосвязь продумать самостоятельно.
    //Исходные данные база (List) из n товаров задать непосредственно в коде (захардкодить).
    //Создать базовый класс Product с методами, позволяющим вывести на экран информацию о товаре, а также определить, соответствует ли она сроку годности на текущую дату.
    //Создать производные классы:
    //Продукт (название, цена, дата производства, срок годности),
    //Партия (название, цена, количество шт, дата производства, срок годности),
    //Комплект (названия, цена, перечень продуктов) со своими методами вывода информации на экран, и определения соответствия сроку годности.
    //Создать базу (List) из n товаров, вывести полную информацию из базы на экран, а также организовать поиск просроченного товара (на момент текущей даты).
    //Submission status
    /// </summary>
    internal class Product
    {
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public DateTime ManufactureDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string ExpirationStatus { get; set; }

        public Product(string productName, int productPrice, DateTime manufactureDate, DateTime expirationDate)
        {
            ProductName = productName;
            ProductPrice = productPrice;
            ManufactureDate = manufactureDate;
            ExpirationDate = expirationDate;
        }

        public override string ToString()
        {
            return $"Item: {ProductName}, cost: {ProductPrice}, mfd: {ManufactureDate}, expiration: {ExpirationDate}";
        }

        public void CheckExpirationDate()
        {
            if (ExpirationDate.Date < DateTime.Now)
            {
                ExpirationStatus = "Product is spoiled";
            }
            else
            {
                   ExpirationStatus = "Product is fresh";
            }

            Console.WriteLine(ExpirationStatus);
        }
    }
}