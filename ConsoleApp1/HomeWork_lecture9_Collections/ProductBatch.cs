using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_homeworks.HomeWork_lecture9_Collections
{
    public class ProductBatch : Product
    {
        public int quantity;
        public ProductItem item;
        public ProductBatch(ProductItem item, int quantity) : base(item, quantity)
        {
            this.item = item;
            this.quantity = quantity;
        }
    }
}