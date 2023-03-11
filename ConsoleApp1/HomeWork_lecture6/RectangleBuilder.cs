using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.HomeWork_lecture6
{
    internal class RectangleBuilder
    {
        public RectangleBuilder()
        {
        }

        public Rectangle CreateRectangle(double firstSide, double secondSide, double thirdSide, double fourthSide)
        {
            if ((firstSide == secondSide) && (secondSide == thirdSide) && (thirdSide == fourthSide))
            {
                return new Square(firstSide, secondSide, thirdSide, fourthSide);
            }

            else if (((firstSide == secondSide) && (thirdSide == fourthSide)) ||
                    ((firstSide == thirdSide) && (secondSide == fourthSide)) ||
                    ((firstSide == fourthSide) && (secondSide == thirdSide)))
            {
                return new Rectangle(firstSide, secondSide, thirdSide, fourthSide);
            }

            else
            {
                Console.WriteLine("Unable to calculate square as a figure is neither rectangle nor a square");
                return null;
            }
        }
    }
}
