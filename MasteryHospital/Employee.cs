using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryHospital
{
    public class Employee
    {
        


        public string EmployeeName { get; set; }
        public int Salary { get; set; }
        public int IDNumber { get; set; }
        public bool Paid { get; set; }
        public string Job { get; set; }


        public Employee()
        {
        }

        public Employee(string employeeName, int iDNumber, int salary, bool paid, string job)
        {
            EmployeeName = employeeName;
            IDNumber = iDNumber;
            Salary = salary;
            Paid = false;
            Job = job;
        }




        public void EmployeeInfo()
        {
                Console.WriteLine($"Employyee {EmployeeName} {IDNumber} {Job} {Salary} {Paid}");
        }

        public void PayEmployees()
        {
            Paid = true;
            if (true)
            {
                Console.WriteLine("You have been paid. Wait until next month.");
            }

        }

        public virtual void DrawBlood()
        {

        }


        }
    }

   

