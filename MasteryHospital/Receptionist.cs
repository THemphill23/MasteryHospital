using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryHospital
{
    class Receptionist : Employee
    {
        public bool Talking { get; set; }

        public Receptionist()
        {
        }

        public Receptionist(string employeeName, int iDNumber, int salary, bool paid, string job) : base( employeeName,  iDNumber,  salary,  paid,  job)
        {
            Talking = true;
        }


    }
}
