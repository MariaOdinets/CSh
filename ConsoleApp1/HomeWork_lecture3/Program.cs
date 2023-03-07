using ConsoleApp1.HomeWork;
using ConsoleApp1.HomeWork_lecture5;
using System.Xml.Linq;

namespace ConsoleApp1.HomeWork1
{
    internal class Program_lecture5
    {
        static void Main()
        {
            CreditCard johnsCard = new CreditCard(111265115456, 123);
            CreditCard davesCard = new CreditCard(2254654513, 0);
            CreditCard katesCard = new CreditCard(3546546541, -500);

            johnsCard.ReplenishCardAccount(1000);
            davesCard.ReplenishCardAccount(1);
            katesCard.WithdrawMoney(500);

            johnsCard.GetInfo();
            davesCard.GetInfo();
            katesCard.GetInfo();
        }

        public void PhoneTask()
        {
            {
                Phone mashasPhone = new Phone(15456465, "Iphone X", 0.144);
                Phone mishasPhone = new Phone(24564464, "Samsung s22");
                Phone grishasPhone = new Phone();

                //grishasPhone.GetInfo();
                //mashasPhone.ReceiveCall("Mike");
                //mashasPhone.ReceiveCall(12356114, "Мила");
                //mashasPhone.SendMessage(13545, 54545465, 46545); 
                //mishasPhone.GetNumber();
            }
        }
    }
}