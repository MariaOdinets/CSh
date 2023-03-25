using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_homeworks.HomeWork_lecture9_Collections
{
    /// <summary>
    ///Полную структуру классов и их взаимосвязь продумать самостоятельно. Исходные данные база (List) из n товаров задать непосредственно в коде (захардкодить).
    //Создать базовый класс Product с методами, позволяющим вывести на экран информацию о товаре, а также определить, соответствует ли она сроку годности на текущую дату.
    //Создать производные классы:
    //Продукт(название, цена, дата производства, срок годности),
    //Партия(название, цена, количество, дата производства, срок годности)
    //Комплект(названия, цена, перечень продуктов) со своими методами вывода информации на экран, и определения соответствия сроку годности.
    //Создать базу(List) из n товаров, вывести полную информацию из базы на экран, а также организовать поиск просроченного товара(на момент текущей даты).
    //Submission status
    /// </summary>
    public abstract class Product
    {
        public string name { get; set; }
        public int price { get; set; }
        public DateTime manufactureDate { get; set; }
        public DateTime expirationDate { get; set; }
        public List<Product> productList { get; set; }

        public virtual void GetInfo()
        {
            foreach(var product in productList)
            {
                Console.WriteLine($"Product {name}, price {price}, mfd {manufactureDate}, exp date {expirationDate}");
            }
        }
        public virtual void CheckExpirationDate()
        {

        }

        public Product(string name, int price, DateTime manufactureDate, DateTime expirationDate)
        {
            this.name = name;
            this.price = price;
            this.manufactureDate = manufactureDate;
            this.expirationDate = expirationDate;
        }

        public Product(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
    }
}
