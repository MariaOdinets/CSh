namespace ConsoleApp1.HomeWork
{
    internal class Homework3
    { /// <summary>
      /// 0. Создайте массив целых чисел. Пусть число для поиска задается с консоли.
      /// Напишете программу, которая выводит сообщение о том, входит ли заданное число в массив или нет. 
      /// </summary>

        public static void Task0()
        {
            int[] numbers = { 1, 3, 7, 8, 99, 48, 55 };

            Console.WriteLine("Enter any number:");
            int input = int.Parse(Console.ReadLine());

            if (numbers.Contains(input))
            {
                Console.WriteLine("Entered number exists in the array");
            }
            else
            {
                Console.WriteLine("Entered number does not exist in the array");
            }
        }

        /// <summary>
        /// Создайте массив целых чисел. 
        /// Пусть число задается с консоли.Если такого числа нет - выведите сообщениe об этом.
        /// Удалите все вхождения заданного числа из массива. В результате должен быть новый массив без указанного числа.
        /// </summary>
        public static void Task1()
        {
            int[] numbers = { 1, 3, 7, 45, 99 };
            Console.WriteLine("Enter any number:");

            int input = int.Parse(Console.ReadLine());

            foreach (int number in numbers)
            {

            }
        }

        /// <summary>
        /// Создайте и заполните массив случайным числами
        /// Для генерации случайного числа используйте метод Random(). 
        /// Пусть будет возможность создавать массив произвольного размера. Пусть размер массива вводится с консоли.
        /// TO DO Выведете максимальное, минимальное и среднее значение.
        /// </summary>
        public static void Task2()
        {
            Random random = new Random();

            Console.WriteLine("Enter any number:");
            int input = int.Parse(Console.ReadLine());

            int[] numbers = new int[input];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = (int)random.NextInt64(-200, 200);
                Console.Write(numbers[i] + " ");
            }
        }


        /// <summary>
        /// Создайте 2 массива из 5 чисел.
        /// Выведите массивы на консоль в двух отдельных строках.
        /// Посчитайте среднее арифметическое элементов каждого массива
        /// Cообщите, для какого из массивов это значение оказалось больше (либо сообщите, что их средние арифметические равны).
        /// </summary>
        public static void Task3()
        {

        }
    }
}