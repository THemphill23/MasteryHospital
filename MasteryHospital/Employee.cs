using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryHospital
{
    class Employee : Hospital
    {

        Doctor doctor = new Doctor();
        Nurse nurse = new Nurse();
        Receptionist receptionist = new Receptionist();
        Janitor janitor = new Janitor();

        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public string EmployeeTitle { get; set; }
        public int EmployeeNumber { get; set; }
        public int EmployeeSalary { get; set; }


        public Employee(string employeeFirstName, string employeeLastName, int IDNumber, int Salary, bool Paid)
        {
            EmployeeFirstName = employeeFirstName;
            EmployeeLastName = employeeLastName;
            IDNumber = 0001;
            Salary = 40000;
            Paid = false;
        }

        public void EmployeeInfo()
        {

        }
        public Employee()
        {
        }

        

        

    }

   
}
