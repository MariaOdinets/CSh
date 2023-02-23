namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            Task3();
            //Task4();
        }


        public static void Task4()
        {
            int number = int.Parse(Console.ReadLine());
            double result;

            if (number < 100)
            {
                result = number * 0.05;
            }
            else if ((number >= 100) && (number <= 200))
            {
                result = number * 0.07;
            }
            else
            {
                result = number * 0.1;
            }
            Console.WriteLine($"Your % plus deposite is {result}");

        }



        public static void Task3()
        {
            int input = int.Parse(Console.ReadLine());

            if ((input > 5) || (input < 10))
            {
                Console.WriteLine("Число больше 5 и меньше 10");
            }
            else
            {
                Console.WriteLine("Неизвестное число");
            }

        }

        public static void Task2()
        {
            int numberOne = 1;
            int numberTwo = 2;

            if (numberOne > numberTwo)
            {
                Console.WriteLine("First number is bigger than second one");
            }
            else
            {
                {
                    Console.WriteLine("Second number is bigger than the first one");
                }
            }
        }

        public static void Task1()
        {
            double r = double.Parse(Console.ReadLine());
            double h = Convert.ToDouble(Console.ReadLine());

            double v = Math.PI * Math.Pow(r, 2) * h;
            double s = 2 * Math.PI * r * (r + h);

            Console.WriteLine($"Square: {s}");
            Console.WriteLine($"Volume: {v}");
        }
    }
}






/*
{
    float p = (float) Math.PI;
    double p2 = Math.PI;
    decimal p3 = (decimal) Math.PI;

    Console.WriteLine($"float, {Math.Round(p, 15)}");
    Console.WriteLine($"double, {p2}");
    Console.WriteLine($"decimal, {p3}");
}
}
} 
*/

/* {
     Console.WriteLine("\nмоя строка 1");

     Console.WriteLine("\tмоя строка 2");

     Console.WriteLine("\aмоя строка 3");
 }
*/
/* {
     double radius = Convert.ToDouble(Console.ReadLine());
     double result = Math.PI * Math.Pow(radius, 2);
     Console.WriteLine(Math.Round(result, 0));

 }
*/



