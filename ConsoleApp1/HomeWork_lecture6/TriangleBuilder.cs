using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.HomeWork_lecture6
{
    internal class TriangleBuilder
    {
        public TriangleBuilder()
        {
        }

        public Triangle CreateTriangle(double firstSide, double secondSide, double thirdSide)
        {
            if ((firstSide == secondSide) && (firstSide == thirdSide))
            {
                return new EquiangularTriangle(firstSide, secondSide, thirdSide);
            }

            else if ((firstSide == secondSide) || (firstSide == thirdSide) || (secondSide == thirdSide))
            {
                return new EquilateralTriangle(firstSide, secondSide, thirdSide);
            }

            else if ((Math.Pow(firstSide, 2) + (Math.Pow(secondSide, 2)) == (Math.Pow(thirdSide, 2))) ||
                    (Math.Pow(firstSide, 2) + (Math.Pow(thirdSide, 2)) == (Math.Pow(secondSide, 2))) ||
                    (Math.Pow(secondSide, 2) + (Math.Pow(thirdSide, 2)) == (Math.Pow(firstSide, 2))))
            {
                return new RightTriangle(firstSide, secondSide, thirdSide);
            }
            else
            {
                return new ScaleneTriangle(firstSide, secondSide, thirdSide);
            }
        }
    }
}
