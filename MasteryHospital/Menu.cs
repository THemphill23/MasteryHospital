using System;

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
                switch (input)
                {
                    case "e":
                        Console.WriteLine("Welcome hospital employee.");
                        EmployeeMenu();
                        break;

                    case "p":
                        Console.WriteLine("Welcome patient.");
                        PatientMenu();
                        break;

                    case "x":
                        inCare = false;
                        Console.WriteLine("Thank you for visiting.");
                        break;

                }
                


            }

            void PatientMenu()
            {
                Console.WriteLine("To view patients in the hospital, press 'P'.");
                Console.WriteLine("To view the status of the patients, press 'S'.");
                string patientChoice = Console.ReadLine();

                switch (patientChoice)
                {

                    

                    case "p":
                        hospital.AddPatients(patient);
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

            void EmployeeMenu()
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
}
