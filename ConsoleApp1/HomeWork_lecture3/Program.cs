using ConsoleApp1.HomeWork;
using ConsoleApp1.HomeWork_lecture5;

namespace ConsoleApp1.HomeWork1
{
    internal class Program_lecture5
    {
        static void Main()
        {
            Phone mashasPhone = new Phone(15456465, "Iphone X", 0.144, "Гриша");

            Phone mishasPhone = new Phone(24564464, "Samsung s22");

            Phone grishasPhone = new Phone();

            //grishasPhone.GetInfo();
            //mashasPhone.ReceiveCall();
            grishasPhone.GetNumber();
        }
    }
}