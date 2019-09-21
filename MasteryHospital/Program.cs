using System;
using System.Collections.Generic;

namespace MasteryHospital
{
    public class Program
    {


        static void Main(string[] args)
        {

            Patient patient = new Patient();
            Employee employee = new Employee();
            Hospital hospital = new Hospital();


            Console.WriteLine("Welcome to Mastery Hospital.");

            bool inCare = true;
            while (inCare)
            {
                Console.WriteLine();
                Console.WriteLine("Are you an employee or patient?");
                Console.WriteLine("Press 'E' for employee list.");
                Console.WriteLine("Press 'P' for patient list.");
                Console.WriteLine("Press 'C' to pay the employees.");
                Console.WriteLine("Press 'B' to draw a patient's blood.");
                Console.WriteLine("Press 'X' to exit program.");
                string input = Console.ReadLine().ToLower();
                switch (input)
                {
                    case "e":
                        Console.Clear();
                        Console.WriteLine("Welcome hospital employee.");
                        hospital.ShowListOfEmployees();
                        break;

                    case "p":
                        Console.Clear();
                        Console.WriteLine("Welcome patient.");
                        hospital.ShowListOfPatients();
                        break;

                    case "c":
                        Console.Clear();
                        Console.WriteLine("You have been payed.");
                        hospital.PayAllEmployees();
                        break;

                    case "b":
                        Console.Clear();
                        Console.WriteLine("You have drawn blood.");
                        hospital.DrawAllBlood();
                        break;

                    case "x":
                        Console.Clear();
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

