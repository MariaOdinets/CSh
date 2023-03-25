using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_homeworks.HomeWork_lecture9_Collections
{
    abstract class ProductSet : Product //IEnumerable
    {
        public ProductSet(string name, int price) : base(name, price)
        {

        }
        public override void GetInfo()
        {
           
        }
        public override void CheckExpirationDate()
        {
            
        }
    }
}
