using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.HomeWork_lecture6
{
    internal class RightTriangle : Triangle
    {
        public RightTriangle(double firstSide, double secondSide, double thirdSide) : base(firstSide, secondSide, thirdSide)
        {

        }
        public override double GetSquare()
        {
            Console.WriteLine("Get square for right triangle");

            if (firstSide > secondSide)
            {
                if (firstSide > thirdSide)
                {
                    return GetSquareRightTriangle(secondSide, thirdSide);
                }
                else
                {
                    return GetSquareRightTriangle(firstSide, secondSide);
                }
            }
            else
            {
                if (secondSide > thirdSide)
                {
                    return GetSquareRightTriangle(firstSide, thirdSide);
                }
                else
                { 
                    return GetSquareRightTriangle(firstSide, secondSide);
                }
            }
        }
        private double GetSquareRightTriangle(double firstSide, double secondSide)
        {
            return 0.5 * firstSide * secondSide;
        }
    }
}

