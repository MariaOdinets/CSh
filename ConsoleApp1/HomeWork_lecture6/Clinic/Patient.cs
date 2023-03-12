using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.HomeWork_lecture6.Clinic
{
    public class Patient
    {
        public string name;
        public string complains;    

        public Patient(string name, string complains)
        {
            this.name = name;
            this.complains = complains;
        }

        Patient patient = new Patient("Tom Walker", "Headache");
    }
}
