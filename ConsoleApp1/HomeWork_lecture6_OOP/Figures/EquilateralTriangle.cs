using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.HomeWork_lecture6.Figures
{
    internal class EquilateralTriangle : Triangle
    {
        public EquilateralTriangle(double firstSide, double secondSide, double thirdSide) : base(firstSide, secondSide, thirdSide)
        {

        }

        public override double GetSquare()
        {
            Console.WriteLine("Square for Equilateral Triangle");
            double halfPerimeter = firstSide + thirdSide / 2;
            return thirdSide / 2 * Math.Sqrt(Math.Pow(firstSide, 2) - Math.Pow(thirdSide, 2) / 4);
            //Math.Sqrt(halfPerimeter * (halfPerimeter - firstSide) * (halfPerimeter - secondSide) * (halfPerimeter - thirdSide));
        }
    }
}