using ConsoleApp1.HomeWork;
using ConsoleApp1.HomeWork_lecture5;
using ConsoleApp1.HomeWork_lecture6;
using ConsoleApp1.HomeWork_lecture6.Clinic;
using ConsoleApp1.HomeWork_lecture6.Figures;
using System.Xml.Linq;
using TMS_homeworks.HomeWork_lecture6.Autopark;

namespace ConsoleApp1.HomeWork1
{
    internal class Program_lecture5
    {
        static void Main()
        {
            Bus bus12 = new Bus("Pivet Drive", 12, "11:38", 12);
            Bus bus27 = new Bus("Sun street", 27, "10:05", 40);
            Subway subway44 = new Subway("Monumentale", 44, "14:55", 133);
            Subway subway793 = new Subway("Pivet Drive", 793, "09:37", 200);
            Tram tram25 = new Tram("King's Cross", 25, "05:40", 40);
            Tram tram3 = new Tram("Monumentale", 3, "07:40", 19);
            Trolleybus trolleybus78 = new Trolleybus("Sun street", 78, "12:04", 17);
            Trolleybus trolleybus5 = new Trolleybus("King's Cross", 5, "23:49", 44);

            PublicTransport[] publicTransports = new PublicTransport[] { bus12, bus27, subway44, subway793, tram25, tram3, trolleybus78, trolleybus5 };

            Array.Sort(publicTransports);

            foreach (var transport in publicTransports)
            {
                Console.WriteLine(transport);
            }
        }

        public static void Clinic()
        {
            Patient patient = new Patient("Tom Walker", "Headache", 3);
            patient.treatmentPlan.AssignDoctor();
        }
        public static void FiguresTask()
        {
            Figures[] figures = new Figures[]{
                new RectangleBuilder().CreateRectangle(4, 4, 4, 4),
                new TriangleBuilder().CreateTriangle(3, 4, 5)
            };
            foreach (var figure in figures)
            {
                Console.WriteLine(figure.GetSquare());
            }
        }
        public void CreditCardTask()
        {
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