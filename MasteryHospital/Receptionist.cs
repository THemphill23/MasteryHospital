﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryHospital
{
    class Receptionist : Employee
    {
        public string Occupation { get; set; }
        public Receptionist() : base("Michelle", "Maximus", 0002, 45000, false)
        {
            Occupation = "Receptionist";
        }

        public void ReceptionistInfo()
        {
            Console.WriteLine(EmployeeFirstName + " " + EmployeeLastName + ", " + EmployeeTitle);
        }

        public void AnswersPhone()
        {

        }
    }
}
