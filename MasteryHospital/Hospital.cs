using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryHospital
{
    class Hospital
    {
        Employee employee = new Employee();
        Patient patient = new Patient();

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
        public void AddEmployee(Employee employee)
        {

            employeesInHospital.Add(employee);

        }

        public void ShowListOfEmployees()
        {
            foreach (Employee employee in employeesInHospital)
                employee.EmployeeInfo();



        }

        public void EmployeeMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("Press 'L' to view the list of employees");
            Console.WriteLine("Press 'S' to pay the employees.");
            Console.WriteLine("Press 'W' to see if the janitor swept.");
            Console.WriteLine("Press 'T' to see if the recptionist is on the phone.");
            string employeeChoice = Console.ReadLine().ToLower();

            switch (employeeChoice)
            {
                case "l":
                    ShowListOfEmployees();
                    break;

                case "s":
                    break;

                case "w":
                    break;

                case "t":
                    break;
            }


        }

        public void PatientMenu()
        {
            Console.WriteLine("To Enter a patient press 'A'.");
            Console.WriteLine("To view patients in the hospital, press 'P'.");
            Console.WriteLine("To view the status of the patients, press 'S'.");
            string patientChoice = Console.ReadLine();

            switch (patientChoice)
            {

                case "a":
                    patient = new Patient();
                    patient.AddPatient();
                    AddPatients(patient);
                    break;

                case "p":
                    ShowListOfPatients();
                    break;

                case "s":
                    ShowStatusOfPatient();
                    break;

                default:
                    Console.WriteLine("There are no patients!");
                    break;
            }
        }
    }
}
