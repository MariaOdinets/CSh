using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_homeworks.HomeWork_lecture11_Delegates
{
    /// <summary>
    /// Cоздать класс мониторинга средней цены на жилье, цена будет генерироваться с помощью класса рандом и выдавать случайное значение в определенном диапазоне. 
    /// Для того, чтобы вывод цены был удобен пользователю, в классе мониторинга создать поле делегат, обьект которого будет создаваться в классе мониторинга.
    /// Пользователь указывает метод для отображения цены в удобном ему формате путем передачи метода в конструктор класса мониторинга.
    /// </summary>
    public class PriceMonitor : IPriceMonitor
    {
        private List<ISubscriber> subscribers = new List<ISubscriber>();

        public delegate void MonitorDelegate(int price);
        public delegate void Action();

        public static void ShowPrice(int price)
        {
            Console.WriteLine($"The rent for this flat is {price}");
        }

        public void Subscribe(ISubscriber subscriber)
        {
            this.subscribers.Add(subscriber);
        }

        public void Unsubscribe(ISubscriber subscriber)
        {
            this.subscribers.Remove(subscriber);
        }
    }
}