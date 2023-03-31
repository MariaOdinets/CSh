using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.HomeWork_lecture6.Figures
{
    internal class Square : Rectangle
    {
        public Square(double firstSide, double secondSide, double thirdSide, double fourthSide) : base(firstSide, secondSide, thirdSide, fourthSide)
        {

        }

        public override double GetSquare()
        {
            Console.WriteLine("Get square for a square");
            return firstSide * 4;
        }
    }
}