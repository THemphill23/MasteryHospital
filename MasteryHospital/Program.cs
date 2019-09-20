using System;
using System.Collections.Generic;

namespace MasteryHospital
{
    public class Program
    {


        static void Main(string[] args)
        {



            Patient newPatient = new Patient();
            Employee employee = new Employee();
            Hospital hospital = new Hospital();

            
            


            Console.WriteLine("Welcome to Mastery Hospital.");

            bool inCare = true;
            while (inCare)
            {

                Console.WriteLine("Are you an employee or patient?");
                Console.WriteLine("Press 'E' for employee or 'P' for patient.");
                Console.WriteLine("Press 'C' to pay the employees.");
                Console.WriteLine("Press 'X' to exit program.");
                string input = Console.ReadLine().ToLower();
                switch (input)
                {
                    case "e":
                        Console.WriteLine("Welcome hospital employee.");
                        hospital.ShowListOfEmployees();
                        break;

                    case "p":
                        Console.WriteLine("Welcome patient.");
                        hospital.ShowListOfPatients();
                        break;

                    case "c":
                        Console.WriteLine("You have been payed.");
                        hospital.PayAllEmployees();
                        break;

                    case "x":
                        inCare = false;
                        Console.WriteLine("Thank you for visiting.");
                        break;

                    default:
                        break;
                }


            }


        }
    }
}

