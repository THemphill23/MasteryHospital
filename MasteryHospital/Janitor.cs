using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryHospital
{
    class Janitor : Employee
    {
        public bool Sweeping { get; set; }
        
        
        public Janitor()
        {
        }

        public Janitor(string employeeName, int iDNumber, int salary, bool paid, string job) : base( employeeName,  iDNumber,  salary,  paid,  job)
        {
            Sweeping = true;
        }

    }
}
