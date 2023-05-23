using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TMS_homeworks.HomeWork_lecture11_Delegates.PriceMonitor;

namespace TMS_homeworks.HomeWork_lecture11_Delegates
{
    /// <summary>
    /// Реализовать паттерн наблюдатель в случае если цена на жилье опустилась ниже определенного значения, и сообщить всем, кто на это событие подписался. 
    /// </summary>
    /// 
    public interface IPriceMonitor
    {
        void Subscribe(ISubscriber subscriber);                         
    }
}