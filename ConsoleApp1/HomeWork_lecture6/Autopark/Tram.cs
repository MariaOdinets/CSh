using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_homeworks.HomeWork_lecture6.Autopark
{
    internal class Tram : PublicTransport
    {
        public Tram(string destination, int number, string departureTime, int numberOfSeats) : base(destination, number, departureTime, numberOfSeats)
        {

        }
        public override string getVehicleType()
        {
            return "Rail";
        }
    }
}