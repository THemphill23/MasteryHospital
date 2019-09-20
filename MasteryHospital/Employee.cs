using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryHospital
{
    public class Employee : Hospital
    {
        Doctor doctor = new Doctor();
        Nurse nurse = new Nurse();
        Receptionist receptionist = new Receptionist();
        Janitor janitor = new Janitor();
        private bool v;
        private int v1;
        private string v2;


        //Properties
        public string EmployeeName { get; set; }
        public int Salary { get; set; }
        public int IDNumber { get; set; }
        public bool Paid { get; set; }



        //Constructor
        public Employee(string employeeName, int IDNumber, int Salary, bool Paid)
        {
            EmployeeName = employeeName;
            IDNumber = 001;
            Salary = 00001;
            Paid = false;
        }

        public Employee()
        {
        }

        public Employee(string employeeName, int IDNumber, int Salary, bool Paid, string v2) : this(employeeName, IDNumber, Salary, Paid)
        {
            this.v = v;
        }

        public Employee(string employeeName, int IDNumber, int Salary, bool Paid, bool v) : this(employeeName, IDNumber, Salary, Paid)
        {
            this.v = v;
        }

        public Employee(string employeeName, int IDNumber, int Salary, bool Paid, int v1) : this(employeeName, IDNumber, Salary, Paid)
        {
            this.v1 = v1;
        }

        public void EmployeeInfo()
        {

        }
    }
}
   

