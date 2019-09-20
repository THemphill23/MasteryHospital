using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryHospital
{
    public class Patient : Hospital
    {

        public string PatientName { get; set; }
        public int PatientBlood { get; set; }
        public int PatientHealth { get; set; }

        public List<Patient> patientsInHospital = new List<Patient>();

        public Patient(string PatientName, int PatientBlood, int PatientHealth)
        {
            PatientBlood = 20;
            PatientHealth = 10;
        }

        public Patient()
        {
        }

        public void DrawBlood()
        {
            PatientBlood--;
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


        public void AddPatientToPatientList()
        {
            patientsInHospital.Add(new Patient("Jordan Jordanson", 20, 10));
            patientsInHospital.Add(new Patient("Frank Johnson", 20, 10));
            patientsInHospital.Add(new Patient("Nancy Williams", 20, 10));
            patientsInHospital.Add(new Patient("Felix Caterson", 20, 10));
            patientsInHospital.Add(new Patient("Gina Smith", 20, 10));



        }


        
    }
}
