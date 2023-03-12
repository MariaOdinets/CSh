using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.HomeWork_lecture6.Clinic
{
    internal class Dentist : Doctor
    {

        public Dentist()
        {
            
        }
        public override string Treat()
        {
            return "Remove this tooth.. now";
        }
    }
}