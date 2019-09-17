using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryHospital
{
    public class Patient
    {

        public string PatientName { get; set; }
        public int PatientBlood { get; set; }
        public int PatientHealth { get; set; }


        public Patient()
        {
            PatientBlood = 20;
            PatientHealth = 10;
        }

        public void AddPatient()
        {
            Console.WriteLine("Add a new Patient");
             PatientName = Console.ReadLine().ToLower();

        }
         public void PatientInfo()
        {
            Console.WriteLine(PatientName);
        }

        public void PatientStatus()
        {
            Console.WriteLine("Patienet blood level:" + PatientBlood);
            Console.WriteLine("Patient health level:" + PatientHealth);
        }

    }
}
