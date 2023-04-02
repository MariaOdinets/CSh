using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TMS_homeworks.HomeWork_Lecture10_Generics
{
    /// <summary>
    /// Напишите обобщенный класс, который может хранить в массиве объекты любого типа. 
    /// Кроме того, данный класс должен иметь методы для добавления данных в массив, удаления из массива, получения элемента из массива по индексу и метод, возвращающий длину массива.
    ///  Для упрощения работы можно пересоздавать массив при каждой операции добавления и удаления
    /// </summary>
    internal class GenericArray<T>
    {
        T[] array;

        GenericArray<T> genericArray = new();        

        public GenericArray() { }
        public GenericArray(T[] array)
        {
            this.array = array;
        }

        public GenericArray(List<T> list)
        {
            array = list.ToArray();
        }

        public static void Add(List<string> list)
        {
            
            string input = Console.ReadLine();

            do
            {
                list.Add(input);
            }
            while (input != null);
        }

        public static void Delete<T>(List<T> list)
        {

        }

        public static void GetElement(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public static void GetLength(T[] array)
        {
            try
            {
                Console.WriteLine(array.GetLength);
            }
            catch
            {
                throw new IndexOutOfRangeException("Index out of range");
            }
        }
    }
}