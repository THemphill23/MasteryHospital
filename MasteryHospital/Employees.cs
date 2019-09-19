using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryHospital
{
    public class Employees
    {

        //Properties
        public string EmployeeName { get; set; }
        public int Salary { get; set; }
        public int IDNumber { get; set; }
        public bool Paid { get; set; } 



        //Constructor
        public Employees(string employeeName, int IDNumber, int Salary, bool Paid)
        {
            EmployeeName = employeeName;
            IDNumber = 001;
            Salary = 00001;
            Paid = false;
        }
        


    }
}
   

