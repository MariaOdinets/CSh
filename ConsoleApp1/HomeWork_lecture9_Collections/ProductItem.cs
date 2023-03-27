using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_homeworks.HomeWork_lecture9_Collections
{
    public class ProductItem : Product
    {
        public ProductItem(string name, int price, DateTime manufactureDate, DateTime expirationDate) : base(name, price, manufactureDate, expirationDate)
        {
           
        }
    }
}