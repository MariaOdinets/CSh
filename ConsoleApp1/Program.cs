namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            // Task2();
            //Task3();

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
                case "/" and : //если ты видишь этот коммент, значит у меня все еще ступор мозговины
                    Console.WriteLine("Cannot divide by 0"); 
                    break;
                case "/":
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

        /* WORK IN PROGRESS

                public static void Task3()
                {
                    Console.WriteLine("Введите слово");
                    string input = Console.ReadLine();


                } */

    }
}

















