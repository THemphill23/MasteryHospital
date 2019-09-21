using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryHospital
{
    public class Hospital
    {
        public List<Patient> patientsInHospital = new List<Patient>()
        {
            new Patient("Jordan Jordanson", 20, 10),
            new Patient("Frank Johnson", 20, 10),
            new Patient("Nancy Williams", 20, 10),
            new Patient("Felix Caterson", 20, 10),
            new Patient("Gina Smith", 20, 10)

        };

        public List<Employee> employeesInHospital = new List<Employee>()
        {
            new Doctor("Dr. Jim Jordan", 0035, 90000, false, "Hand Doctor"),
            new Doctor("Dr. Rollie Fingers", 0039, 90000, false, "Foot Doctor"),
            new Doctor("Dr. Lefty Mcgee", 0042, 90000, false, "Eye Doctor"),
            new Doctor("Dr. Alden Kimbrell", 0087, 90000, false, "Nose Doctor"),
            new Doctor("Dr. Larry Evans", 0901, 90000, false, "Hair Docotr"),

            new Nurse("Melissa Jordan", 0098, 50000, false, "Nurse"),
            new Nurse("Megan Frank", 0079, 50000, false, "Nurse"),
            new Nurse("Nancy Mcgee", 0046, 50000, false, "Nurse"),
            new Nurse("Julie Santos", 0080, 50000, false, "Nurse"),
            new Nurse("Katie Williams", 0907, 50000, false, "Nurse"),

            new Janitor("Myles Power", 0035, 40000, false, "Janitor"),
            new Janitor("Teeth O'Brian", 0039, 40000, false, "Janitor"),

            new Receptionist("Brandy Best", 0035, 45000, false, "Receptionist"),
            new Receptionist("Thomas Trust", 0039, 45000, false, "Receptionist"),
            new Receptionist("Ryan Lopeda", 0042, 45000, false, "Receptionist"),


        };

        public void ShowListOfEmployees()
        {
            foreach (Employee employee in employeesInHospital)
                employee.EmployeeInfo();
        }

        public void ShowListOfPatients()
        {
            foreach (Patient patient in patientsInHospital)
                patient.PatientInfo();
        }

        public void PayAllEmployees()
        {
            foreach (Employee employee in employeesInHospital)
                employee.PayEmployees();
            if (true)
            {
                Console.WriteLine("You have been paid. Wait until next month.");
            }

        }

        public void DrawAllBlood()
        {
            foreach (Patient patient in patientsInHospital)
                patient.DrawBlood();
            
        }

    }
}
