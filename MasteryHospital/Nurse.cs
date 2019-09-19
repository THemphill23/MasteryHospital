using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryHospital
{
    class Nurse : Employees
    {

        public int NumberOfPatients { get; set; }


        public Nurse(string employeeName, int IDNumber, int Salary, bool Paid, int NumberOfPatients) : base("Melissa Jordan", 0098, 0001, false)
        {

           NumberOfPatients = 100;

        }




        //List

        public List<Nurse> nurseList = new List<Nurse>();

            
        
        
        //Methods

        //Add To List 
        
        
        public void AddNurseToNurseList()
        {

            nurseList.Add(new Nurse("Melissa Jordan", 0098, 0001, false, 7));
            nurseList.Add(new Nurse("Megan Frank", 0079, 0001, false, 3));
            nurseList.Add(new Nurse("Nancy Mcgee", 0046, 0001, false, 72));
            nurseList.Add(new Nurse("Julie Santos", 0080, 0001, false, 12));
            nurseList.Add(new Nurse("Katie Williams", 0907, 0001, false, 14));

            

        }



       


    }
}
