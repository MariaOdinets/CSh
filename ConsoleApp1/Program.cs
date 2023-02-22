namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Task1();
            Task2();
        }


        public static void Task2()
        {
            int numberOne = 1; 
            int numberTwo = 2;

            if (numberOne > numberTwo) 
            {
                Console.WriteLine("First number is bigger than second");
            } else
            {
                {
                    Console.WriteLine("Second number is bigger than first one");
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



