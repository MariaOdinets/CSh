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
        /// Пусть число задается с консоли.
        /// Удалите все вхождения заданного числа из массива. Если такого числа нет - выведите сообщениe об этом.
        /// В результате должен быть новый массив без указанного числа.
        /// </summary>
        public static void Task1()
        {
            int[] numbers = { 1, 3, 7, 45, 99, 99, 99 };
            int counter = 0;

            Console.WriteLine("Enter any number:");
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == input)
                {
                    counter++;
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("Entered number does not exist in the array");
                return;
            }

            int[] numbersFinal = new int[numbers.Length - counter];

            for (int i = 0, j = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != input)
                {
                    numbersFinal[j] = numbers[i];
                    j++;
                }
            }

            foreach (int number in numbersFinal)
            {
                Console.Write(number + " ");
            }
        }

        /// <summary>
        /// Создайте и заполните массив случайным числами
        /// Для генерации случайного числа используйте метод Random(). 
        /// Пусть будет возможность создавать массив произвольного размера. Пусть размер массива вводится с консоли.
        /// Выведете максимальное, минимальное и среднее значение.
        /// </summary>
        public static void Task2()
        {
            Random random = new Random();

            Console.WriteLine("Enter any number:");
            int input = int.Parse(Console.ReadLine());

            int[] numbers = new int[input];

            int minValue = int.MaxValue;
            int maxValue = int.MinValue;
            double average = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = (int)random.NextInt64();
                Console.Write(numbers[i] + " ");

                average += numbers[i];

                if (numbers[i] < minValue)
                {
                    minValue = numbers[i];
                }
                else if (numbers[i] > maxValue)
                {
                    maxValue = numbers[i];
                }
            }
            average /= input;

            Console.Write($"\nMin array value is {minValue}, max array value is {maxValue}, average is {Math.Round(average, 2)}");
        }

        /// <summary>
        /// Создайте 2 массива из 5 чисел.
        /// Выведите массивы на консоль в двух отдельных строках.
        /// Посчитайте среднее арифметическое элементов каждого массива
        /// Cообщите, для какого из массивов это значение оказалось больше (либо сообщите, что их средние арифметические равны).
        /// </summary>
        public static void Task3()
        {
            Random random = new Random();

            int[] numbers1 = new int[5];
            int[] numbers2 = new int[5];

            double average1 = numbers1[0];
            double average2 = numbers2[0];

            for (int i = 0; i < numbers1.Length; i++)
            {
                numbers1[i] = (int)random.NextInt64(1, 10);
                Console.Write(numbers1[i] + " ");
                average1 += numbers1[i];
            }
            average1 /= numbers1.Length;

            Console.WriteLine();

            for (int i = 0; i < numbers1.Length; i++)
            {
                numbers2[i] = (int)random.NextInt64(11, 20);
                Console.Write(numbers2[i] + " ");
                average2 += numbers2[i];
            }
            average2 /= numbers2.Length;

            if (average1 < average2)
            {
                Console.WriteLine("\nThe arithmetic average of second array is bigger");
            }
            else if (average1 == average2)
            {
                Console.WriteLine("\nThe arithmetic average of two arrays is equal");
            }
            else
            {
                Console.WriteLine("\nThe arithmetic average of first array is bigger");
            }
        }
    }
}