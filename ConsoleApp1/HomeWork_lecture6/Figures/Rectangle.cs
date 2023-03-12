using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.HomeWork_lecture6.Figures
{
    public class Rectangle
    {
        public double firstSide;
        public double secondSide;
        public double thirdSide;
        public double fourthSide;

        public Rectangle(double firstSide, double secondSide, double thirdSide, double fourthSide)
        {
            this.firstSide = firstSide;
            this.secondSide = secondSide;
            this.thirdSide = thirdSide;
            this.fourthSide = fourthSide;
        }

        public double GetSquare()
        {
            Console.WriteLine("Get square for a rectangle");
            if (firstSide != secondSide)
            {
                return firstSide * secondSide;
            }
            else
            {
                return firstSide * thirdSide;
            }
        }
    }
}
