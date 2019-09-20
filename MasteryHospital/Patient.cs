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
                Console.WriteLine($"Patient {PatientName} {PatientBlood} {PatientHealth}");
        }

        //public void DrawBlood()
        //{
        //    PatientBlood--;
        //}

        // public void PatientInfo()
        //{
        //}

        //public void PatientStatus()
        //{
        //    Console.WriteLine("Patienet blood level:" + PatientBlood);
        //    Console.WriteLine("Patient health level:" + PatientHealth);
        //}


        //public void AddPatientToPatientList()
        //{


        //patient.PatientInfo();

        //}

        //public void ShowListOfPatients(List<Patient> patientsInHospital)
        //{

        //    foreach (Patient patient in patientsInHospital)
            
        //        Console.WriteLine($"Patient {PatientName} {PatientBlood} {PatientHealth}");
            
        //}





    }
}
