using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryHospital
{
    public class Hospital
    {

        public Employee employee = new Employee();
        public Patient patient = new Patient();

        public List<Patient> patientsInHospital = new List<Patient>();
        public List<Employee> employeesInHospital = new List<Employee>();

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

        public void ShowListOfEmployees()
        {
            foreach (Employee employee in employeesInHospital)
                employee.EmployeeInfo();
        }
        


        

       


    }
}
