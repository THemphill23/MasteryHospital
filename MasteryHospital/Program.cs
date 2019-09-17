using System;

namespace MasteryHospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient patient = new Patient();
            Hospital hospital = new Hospital();

            bool inCare = true;
            while (inCare)
            {

            Console.WriteLine("Welcome to Mastery Hospital.");
            Console.WriteLine("To Enter a Patient press 'A'.");
            Console.WriteLine("To View Patients in the hospital, press 'P'.");
            Console.WriteLine("To view the status of the patients, press 'S'.");
            string input = Console.ReadLine();

            switch (input)
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
            

        }
    }
}
