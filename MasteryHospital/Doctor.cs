using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MasteryHospital
{
    public class Doctor : Employee
    {

        public string Specialty { get; set; }
    

        public Doctor(string employeeName, int IDNumber, int Salary, bool Paid, string Specialty) : base("Dr. Victoria Johnson", 0035, 0001, false, "hand")
        {
            Specialty = "hand";
        }

        public Doctor()
        {
        }



        //List

        public List<Doctor> doctorsList = new List<Doctor>();



        //Methods

        //Add To List
        
        
        public void AddDoctorToDoctorList()
        {

            doctorsList.Add(new Doctor("Dr. Jim Jordan", 0035, 0001, false, "hand"));
            doctorsList.Add(new Doctor("Dr. Rollie Fingers", 0039, 0001, false, "foot"));
            doctorsList.Add(new Doctor("Dr. Lefty Mcgee", 0042, 0001, false, "eye"));
            doctorsList.Add(new Doctor("Dr. Alden Kimbrell", 0087, 0001, false, "nose"));
            doctorsList.Add(new Doctor("Dr. Larry Evans", 0901, 0001, false, "hair"));

        }




        


    }
}

