using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryHospital
{
    public class Patient
    {

        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }
        public int BloodLevel { get; set; }
        public int HealthLevel { get; set; }


        public Patient()
        {
            BloodLevel = 20;
            HealthLevel = 10;
        }

        public void AddPatient()
        {
            Console.WriteLine("Let's add a new patient.");
            Console.WriteLine("Enter patient first name:");
             PatientFirstName = Console.ReadLine().ToLower();

            Console.WriteLine("Enter patient last name:");
            PatientLastName = Console.ReadLine().ToLower();

        }
         public void PatientInfo()
        {
            Console.WriteLine(PatientFirstName + " " + PatientLastName);
        }

        public void PatientStatus()
        {
            Console.WriteLine("Patient blood level:" + BloodLevel);
            Console.WriteLine("Patient health level:" + HealthLevel);
        }

        

    }
}
