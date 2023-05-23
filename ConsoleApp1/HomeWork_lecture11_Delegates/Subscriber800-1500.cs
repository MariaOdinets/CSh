using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_homeworks.HomeWork_lecture11_Delegates
{
    public class Subscriber300_800 : ISubscriber
    {
        public int price { get; set; }
        public void InformSubscribers(IPriceMonitor monitor, int price)
        {
            if (price >= 800 && price <= 1500)
            {
                {
                    Console.WriteLine($"This luxury flat is only for ${price}/month!");
                }
            }
        }
    }
}
