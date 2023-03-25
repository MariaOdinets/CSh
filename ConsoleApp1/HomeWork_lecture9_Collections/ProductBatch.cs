using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_homeworks.HomeWork_lecture9_Collections
{
    public abstract class ProductBatch : Product
    {
        public int quantity;
        public ProductBatch(string name, int price, DateTime manufactureDate, DateTime expirationDate, int quantity) : base(name, price, manufactureDate, expirationDate)
        {
            this.quantity = quantity;
        }
    }
}
