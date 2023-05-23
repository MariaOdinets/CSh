using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_homeworks.HomeWork_lecture11_Delegates
{
    public class Subscriber300_500 : ISubscriber
    {
        public int price { get; set; }
        public void InformSubscribers(IPriceMonitor monitor, int price)
        {
            if (price < 500)
            {
                {
                    Console.WriteLine($"Today is the lowest price! Only ${price} for this small and cozy flat");
                }
            }
        }
    }
}