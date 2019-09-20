using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryHospital
{
    public class Patient
    {
        //public List<Patient> patientsInHospital = new List<Patient>()
        //{
        //    new Patient("Jordan Jordanson", 20, 10),
        //    new Patient("Frank Johnson", 20, 10),
        //    new Patient("Nancy Williams", 20, 10),
        //    new Patient("Felix Caterson", 20, 10),
        //    new Patient("Gina Smith", 20, 10)
        //};

        public string PatientName { get; set; }
        public int PatientBlood { get; set; }
        public int PatientHealth { get; set; }


        public Patient()
        {
        }

        public Patient(string PatientName, int PatientBlood, int PatientHealth)
        {
            PatientBlood = 20;
            PatientHealth = 10;
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

        public void ShowListOfPatients(List<Patient> patientsInHospital)
        {
            foreach (Patient patient in patientsInHospital)
                Console.WriteLine($"Patient {PatientName} {PatientBlood} {PatientHealth}");
        }





    }
}
