using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.HomeWork_lecture6.Clinic
{
    public class TreatmentPlan
    {
        int treatmentCode;
        Doctor doctor;
        Patient patient;
        public TreatmentPlan(int treatmentCode, Patient patient)
        {
            this.treatmentCode = treatmentCode;
            this.patient = patient;
        }

        public void AssignDoctor()
        {
            if (treatmentCode == 1)
            {
                Console.WriteLine($"Patient {patient.patientName} with {patient.complains} is directed to the Surgeon");
                doctor = new Surgeon();
                doctor.Treat();
            }
            else if (treatmentCode == 2)
            {
                Console.WriteLine($"Patient {patient.patientName} with {patient.complains} is directed to the Dentist");
                doctor = new Dentist();
                doctor.Treat();
            }
            else
            {
                Console.WriteLine($"Patient {patient.patientName} with {patient.complains} is directed to the Physician");
                doctor = new Physician();
                doctor.Treat();
            }
        }
    }
}