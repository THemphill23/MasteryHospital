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
            new Doctor("Dr. Jim Jordan", 0035, 90000, false, "hand"),
            new Doctor("Dr. Rollie Fingers", 0039, 90000, false, "foot"),
            new Doctor("Dr. Lefty Mcgee", 0042, 90000, false, "eye"),
            new Doctor("Dr. Alden Kimbrell", 0087, 90000, false, "nose"),
            new Doctor("Dr. Larry Evans", 0901, 90000, false, "hair"),

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
        }

        //public void ShowListOfPatients(List<Patient> patientsInHospital)
        //{

        //    foreach (Patient patient in patientsInHospital)
        //    {
        //        Console.WriteLine($"Patient {PatientName} {PatientBlood} {PatientHealth}");
        //    }
        //    int selectedpatientsInHospitalNumber = Convert.ToInt32(Console.ReadLine());


        //    return hospital.allpatientsInHospital[selectedpatientsInHospital - 1];
        //}
        //public List<Doctor> doctorsList = new List<Doctor>()
        //{

        //    new Doctor("Dr. Jim Jordan", 0035, 0001, false, "hand"),
        //    new Doctor("Dr. Rollie Fingers", 0039, 0001, false, "foot"),
        //    new Doctor("Dr. Lefty Mcgee", 0042, 0001, false, "eye"),
        //    new Doctor("Dr. Alden Kimbrell", 0087, 0001, false, "nose"),
        //    new Doctor("Dr. Larry Evans", 0901, 0001, false, "hair"),

        //};

        //public List<Janitor> janitorList = new List<Janitor>()
        //{
        //    new Janitor("Myles Power", 0035, 0001, false, "Janitor"),
        //    new Janitor("Teeth O'Brian", 0039, 0001, false, "Janitor"),

        //};

        //public List<Nurse> nurseList = new List<Nurse>()
        //{

        //    new Nurse("Melissa Jordan", 0098, 0001, false, "Nurse"),
        //    new Nurse("Megan Frank", 0079, 0001, false, "Nurse"),
        //    new Nurse("Nancy Mcgee", 0046, 0001, false, "Nurse"),
        //    new Nurse("Julie Santos", 0080, 0001, false, "Nurse"),
        //    new Nurse("Katie Williams", 0907, 0001, false, "Nurse"),
        //};

        //public List<Receptionist> receptionistList = new List<Receptionist>()
        //{

        //    new Receptionist("Brandy Best", 0035, 0001, false, "Nurse"),
        //    new Receptionist("Thomas Trust", 0039, 0001, false, "Nurse"),
        //    new Receptionist("Ryan Lopeda", 0042, 0001, false, "Nurse"),
        //};



    }
}
