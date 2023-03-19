using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_homeworks.HomeWork_lecture6.Autopark
{
    internal class Trolleybus : PublicTransport
    {
        public Trolleybus(string destination, int number, string departureTime, int numberOfSeats) : base(destination, number, departureTime, numberOfSeats)
        {

        }
        public VehicleType getVehicleType()
        {
            return VehicleType.Electric;
        }
    }
}