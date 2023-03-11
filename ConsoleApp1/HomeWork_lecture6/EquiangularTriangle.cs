using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.HomeWork_lecture6
{
    internal class EquiangularTriangle : Triangle
    {
        public EquiangularTriangle(double firstSide, double secondSide, double thirdSide) : base(firstSide, secondSide, thirdSide)
        {

        }

        public override double GetSquare()
        {
            Console.WriteLine("Square for Equiangular Triangle");
            return Math.Pow(firstSide, 2) * Math.Sqrt(3) / 4;
        }
    }
}