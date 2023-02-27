namespace ConsoleApp1.HomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            Task4();
        }

        public static void Task1()
        {
            int operand1 = 2;
            int operand2 = 0;

            int result;

            Console.WriteLine("Please enter an arithmetic operator : \"+\", \"-\", \"*\" or \"\\\"");
            string sign = Console.ReadLine();

            switch (sign)
            {
                case "+":
                    result = operand1 + operand2;
                    Console.WriteLine(result);
                    break;
                case "-":
                    result = operand1 - operand2;
                    Console.WriteLine(result);
                    break;
                case "*":
                    result = operand1 * operand2;
                    Console.WriteLine(result);
                    break;
                case "/":
                    if (operand2 == 0)
                    {
                        Console.WriteLine("Cannot divide by 0");
                        break;
                    }

                    result = operand1 / operand2;
                    Console.WriteLine(result);
                    break;
                default:
                    Console.WriteLine("Invalid character, please try again");
                    break;
            }
        }
        public static void Task2()
        {
            Console.WriteLine("Please enter any number from 0 to 100");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case <= 14 and >= 0:
                    Console.WriteLine("Entered number is between 0 and 14");
                    break;
                case >= 15 and <= 35:
                    Console.WriteLine("Entered number is between 15 and 35");
                    break;
                case >= 36 and <= 49:
                    Console.WriteLine("Entered number is between 36 and 49");
                    break;
                case >= 50 and <= 100:
                    Console.WriteLine("Entered number is between 50 and 100");
                    break;
                default:
                    Console.WriteLine("Oops.. Entered number is out of requested range. Please try again");
                    break;
            }
        }

        public static void Task3()
        {
            Console.WriteLine("Введите слово для описания погоды");
            string input = Console.ReadLine();

            if (input == "Холодно")
            {
                Console.WriteLine("cold");
            }
            else if (input == "Солнечно")
            {
                Console.WriteLine("sunny");
            }
            else if (input == "Жарко")
            {
                Console.WriteLine("hot");
            }
            else if (input == "Туманно")
            {
                Console.WriteLine("foggy");
            }
            else if (input == "Дождливо")
            {
                Console.WriteLine("rainy");
            }
            else if (input == "Снежно")
            {
                Console.WriteLine("snowy");
            }
            else if (input == "Ветрено")
            {
                Console.WriteLine("windy");
            }
            else if (input == "Облачно")
            {
                Console.WriteLine("cloudy");
            }
            else if (input == "Прохладно")
            {
                Console.WriteLine("cool");
            }
            else if (input == "Морозно")
            {
                Console.WriteLine("frosty");
            }
            else
            {
                Console.WriteLine("Перевод для слова отсутствует :("); //Пока так , если успею , попробую найти регистронезависимое решение 
            }
        }

        public static void Task4()
        {
            Console.WriteLine("Enter any number");
            int input = int.Parse(Console.ReadLine());
            if (input % 2 == 0)
            {
                Console.WriteLine("Entered number is even");
            }
            else
            {
                Console.WriteLine("Entered number is uneven");
            }
        }
    }
}