using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.HomeWork_lecture6.Clinic
{
    internal class TreatmentPlan
    {
        int treatmentCode;
        public TreatmentPlan(int treatmentCode)
        {
            this.treatmentCode = treatmentCode;
        }

         public virtual string AssignDoctor(int treatmentCode)
        {
            if (treatmentCode == 1)
            {
                Console.WriteLine("Patient is directed to the Surgeon");
                return null;
            }
            else if (treatmentCode == 2)
            {
                return "Patient is directed to the Dentist";
            }
            else
            {
                return "Patient is directed to the Physician";
            }
        }
    }
}
