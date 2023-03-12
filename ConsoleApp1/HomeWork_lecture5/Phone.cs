using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.HomeWork_lecture5
{
    /// <summary>
    /// Класс Phone.  
    // Создайте класс Phone, который содержит переменные number, model и weight.
    // Добавить конструктор в класс Phone, который принимает на вход три параметра для инициализации переменных класса - number, model и  weight.
    // Добавить конструктор, который принимает на вход два параметра для инициализации переменных класса - number, model.
    // Вызвать из конструктора с тремя параметрами конструктор с двумя.
    // Добавить конструктор без параметров.
    // Создайте три экземпляра этого класса.  
    // Выведите на консоль значения их переменных.
    // Добавить в класс Phone методы: receiveCall, имеет один параметр – имя звонящего. Выводит на консоль сообщение “Звонит {name}”.
    // И getNumber –  возвращает номер телефона.Вызвать эти методы для каждого из  объектов.
    // Добавьте перегруженный метод receiveCall, который принимает два параметра - имя звонящего и номер телефона звонящего. Вызвать этот  метод.  
    // Создать метод sendMessage с аргументами переменной длины.Данный метод принимает на вход номера телефонов, которым будет отправлено сообщение. Метод выводит на консоль номера этих телефонов.
    /// </summary>
    internal class Phone
    {
        public int number; 
        public string model;
        public double weight;

        public Phone() : this(111111111, "Nokia 3310")
        {

        }

        public Phone(int number, string model) : this(number, model, 0.105)
        {

        }

        public Phone(int number, string model, double weight)
        {
            this.number = number;
            this.model = model;
            this.weight = weight;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Phone number: {number}, model: {model}, weight: {weight}");
        }

        public void ReceiveCall(string name)
        {
            Console.WriteLine($"Звонит {name}");
        }

        public void GetNumber()
        {
            Console.WriteLine($"Number: {number}");
        }

        public void ReceiveCall(int number, string name)
        {
            Console.WriteLine($"Звонит {number}, {name}");
        }

        public void SendMessage(params int[] numbers)
        {
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}