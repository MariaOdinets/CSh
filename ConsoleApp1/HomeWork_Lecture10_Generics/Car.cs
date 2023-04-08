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
    abstract class Car<T>
    {
        public T Engine { get; set; }

        public Car() { }
    }
}