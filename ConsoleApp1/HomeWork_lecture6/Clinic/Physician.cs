using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.HomeWork_lecture6.Clinic
{
    internal class Physician : Doctor
    {
        public Physician()
        {

        }
        public override void Treat()
        {
            Console.WriteLine("Medical conclusion: Have a rest and take some vitamins");
        }
    }
}