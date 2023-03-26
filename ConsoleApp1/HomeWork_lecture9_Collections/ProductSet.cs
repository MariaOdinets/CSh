using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_homeworks.HomeWork_lecture9_Collections
{
    public class ProductSet : Product //IEnumerable
    {
        public ProductItem item;
        public List<ProductItem> ProductItems { get; }
        public ProductSet(List<ProductItem> productItems)
        {
            ProductItems = productItems;
        }

        public override void GetInfo()
        {
           
        }
        public override void CheckExpirationDate()
        {
            
        }
    }
}
