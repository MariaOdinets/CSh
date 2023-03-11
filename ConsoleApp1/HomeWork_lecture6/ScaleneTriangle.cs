using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.HomeWork_lecture6
{
    internal class ScaleneTriangle : Triangle
    {
        public ScaleneTriangle(double firstSide, double secondSide, double thirdSide) : base(firstSide, secondSide, thirdSide)
        {

        }

        public new double GetSquare()
        {
            return base.GetSquare();
        }
    }
}
