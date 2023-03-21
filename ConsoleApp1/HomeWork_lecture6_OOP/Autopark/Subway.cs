﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_homeworks.HomeWork_lecture6.Autopark
{
    internal class Subway : PublicTransport
    {
        public Subway(string destination, int number, string departureTime, int numberOfSeats) : base(destination, number, departureTime, numberOfSeats)
        {

        }
        public VehicleType getVehicleType()
        {
            return VehicleType.Rail;
        }
    }
}
