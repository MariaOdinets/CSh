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
        public GenericArray(T[] array)
        {
            this.array = array;
        }

        public GenericArray(List<T> list)
        {
            array = list.ToArray();
        }

        public void Add(T value)
        {
            List<T> list = new(array);

            list.Add(value);

            array = list.ToArray();
        }

        public void Delete(T value)
        {
            List<T> list = new(array);

            for (int i = 0; i < list.Count; i++)
            {
                if (object.Equals(list[i], value))
                {
                    list.RemoveAt(i);
                }
            }
            array = list.ToArray();
        }

        public T GetElement(int index)
        {
            try
            {
                return array[index];
            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("Index out of bounds");
                return default;
            }
        }

        public void GetLength()
        {
            Console.WriteLine(array.Length);           
        }

        public void Print()
        {
            foreach (T value in array)
            {
                Console.Write(value + " ");
            }
        }
    }
}