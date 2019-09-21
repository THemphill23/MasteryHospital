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
        }

        public Patient(string patientName, int patientBlood, int patientHealth)
        {
            PatientName = patientName;
            PatientBlood = patientBlood;
            PatientHealth = patientHealth;
        }

        public void PatientInfo()
        {
                Console.WriteLine($" {PatientName} {PatientBlood} {PatientHealth}");
        }

        public void DrawBlood()
        {
            PatientBlood --;
        }


    }
}
