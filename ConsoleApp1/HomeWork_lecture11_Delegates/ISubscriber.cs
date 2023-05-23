using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_homeworks.HomeWork_lecture11_Delegates
{
    public interface ISubscriber
    {
        void InformSubscribers(IPriceMonitor monitor, int price);
    }
}