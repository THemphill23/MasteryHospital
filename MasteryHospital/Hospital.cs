using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryHospital
{
    class Hospital
    {
        
      

        public void AddPatients(Patient patient)
        {
            patientsInHospital.Add(patient);
        }

        public void ShowListOfPatients()
        {
            foreach (Patient patient in patientsInHospital)
                patient.PatientInfo();
        }
        public void ShowStatusOfPatient()
        {
            foreach (Patient patient in patientsInHospital)
            {
                patient.PatientStatus();
                Console.WriteLine();
            }
        }
    }
}
