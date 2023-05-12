using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_homeworks.HomeWork_Lecture10_Generics
{/// <summary>
 /// Реализовать класс машина, у которого будет обобщенное поле двигатель. 
 /// Создать иерархию наследования для двигателей (абстрактный, дизельный, бензиновый, электро). 
 /// Сделать так, чтобы создать автомобиль можно было только передавая туда один из типов двигателя. 
 /// Реализовать методы для движения автомобиля и заправки в зависимости от типа двигателя.
 /// </summary>
    internal class Car<T> where T : Engine
    {
        public T Engine { get; set; }

        public Car(T Engine) 
        {
            this.Engine = Engine;
        }

        public void Move()
        {
            Console.WriteLine($"A car is moving using {Engine.Type} engine");
        }

        public void Refill()
        {
            Console.WriteLine($"A car is refilled with {Engine.FuelType}");
        }
    }
}