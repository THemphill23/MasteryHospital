using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryHospital
{
    class Menu
    {
            Patient patient = new Patient();
            Hospital hospital = new Hospital();
            Employee employee = new Employee();

        public void HospitalMenu()
        {

            bool inCare = true;
            while (inCare)
            {

                Console.WriteLine("Are you an employee or patient?");
                Console.WriteLine("Press 'E' for employee or 'P' for patient.");
                Console.WriteLine("Press 'X' to exit program.");
                string input = Console.ReadLine().ToLower();
                if (input == "e")
                    Console.WriteLine("Welcome hospital employee.");
                hospital.EmployeeMenu();
                
                else if (input == "p")
                    Console.WriteLine("Welcome patient.");
                hospital.PatientMenu();
                   
               
                else
                    inCare = false;
                Console.WriteLine("Thank you for visiting.");

                Console.WriteLine("To view hospital employees press 'E'.");

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
                    hospital.AddPatients(patient);
                    break;

                case "p":
                    hospital.ShowListOfPatients();
                    break;

                case "s":
                    hospital.ShowStatusOfPatient();
                    break;

                default:
                    Console.WriteLine("There are no patients!");
                    break;
            }
        }

        public void EmployeeMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("Press 'L' to view the list of employees");
            Console.WriteLine("Press 'S' to pay the employees.");
            Console.WriteLine("Press 'W' to see if the janitor swept.");
            Console.WriteLine("Press 'T' to see if the recptionist is on the phone.");
            string employeeChoice = Console.ReadLine().ToLower();

            switch(employeeChoice)
            {
                case "l":
                    hospital.ShowListOfEmployees();
                    break;

                 case "s":
                    break;

                case "w":
                    break;

                case "t":
                    break;
            }

        }
    }
}
