using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryHospital
{
    class Janitor: Employee
    {
        public string Occupation { get; set; }
        public Janitor() : base("George", "Festis", 0001, 40000, false)
        {
            Occupation = "Janitor";
        }

        public void JanitorInfo()
        {
            Console.WriteLine(EmployeeFirstName + " " + EmployeeLastName + ", " + EmployeeTitle);
        }

        public void SweepFloors()
        {

        }

        
    }
}
