using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TMS_homeworks.HomeWork_lecture6.Autopark
{/// <summary>
 /// Автопарк✨
    //Создать класс cо следующими свойствами: 
    //сlass Bus: Пункт назначения, Номер, Время отправления, Число мест
    //Определить get, set методы для этих свойств.
    //Создать класс с main методом, в котором будет объявлен объект класса Bus.Вывести все данные (значения полей) объекта в консоль. 

    // Определить иерархию классов в предметной области: Парк общественного траспорта.
    // Определить иерархию различных видов общественного транспорта (например, Trolleybus, Tramcar и т.д.наподобие класса Bus выше.)
    // Определить в суперклассе(например, сlass Transport) метод, возвращающий тип транспорта(Electric, Rail, и т.п.). Переопределить этот метод в классах наследниках.

    //В классе с main методом создать массив объектов из различных видов транспорта.
    //Провести сортировку транспорта по количеству мест и вывести данные объектов в консоль.
    //Запросить у пользователя время отправления и/или пункт назначения.Найти в массиве объект, соответствующий заданным параметрам, и вывести его данные в консоль. 
    //Запросить у пользователя время отправления.Вывести в консоль список транспорта, отправляющегося после заданного времени.

    //Выбрать метод в супеклассе (e.g.Transport), который нельзя будет переопределить в классах наследниках и запретить это переопределение.
    //Создать класс TransportService. Определить внутри класса TransportService метод printTransportType, который будет принимать объект типа Transport как параметр. 
    //Внутри метода printTransportType необходимо вызвать другой метод, возвращающий тип транспорта и вывести эту информацию на консоль.
    //В main вызвать метод printTransportType несколько раз, передавая ему как параметр объекты классов наследников (Bus, Trolleybus и т.д.)
    /// </summary>
    public abstract class PublicTransport : IVehicleType
    {
        public string destination { get; set; }
        public int number { get; set; }
        public string departureTime { get; set; }
        public int numberOfSeats { get; set; }

        public PublicTransport(string destination, int number, string departureTime, int numberOfSeats)
        {
            this.destination = destination;
            this.number = number;
            this.departureTime = departureTime;
            this.numberOfSeats = numberOfSeats;
        }

        public virtual string getVehicleType()
        {            
            return "default type";
        }
    }
}