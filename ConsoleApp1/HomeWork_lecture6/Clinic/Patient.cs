using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.HomeWork_lecture6.Clinic
{
    public class Patient
    {
        public string patientName;
        public string complains;
        public TreatmentPlan treatmentPlan;

        public Patient(string patientName, string complains, int treatmentCode)
        {
            this.patientName = patientName;
            this.complains = complains;
            this.treatmentPlan = new TreatmentPlan(treatmentCode, this);
        }        
    }
}