using ConsoleApp1.HomeWork;
using ConsoleApp1.HomeWork_lecture5;
using System.Xml.Linq;

namespace ConsoleApp1.HomeWork1
{
    internal class Program_lecture5
    {
        static void Main()
        {
            Phone mashasPhone = new Phone(15456465, "Iphone X", 0.144);

            Phone mishasPhone = new Phone(24564464, "Samsung s22");

            Phone grishasPhone = new Phone();

            //grishasPhone.GetInfo();
            //mashasPhone.ReceiveCall("Mike");
            //mashasPhone.ReceiveCall(12356114, "Мила");
            mashasPhone.SendMessage(13545, 54545465, 46545);
            // mishasPhone.GetNumber();

        }
    }
}