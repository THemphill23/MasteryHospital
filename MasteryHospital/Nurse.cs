using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryHospital
{
    class Nurse : Employee
    {

        public int NumberOfPatients { get; set; }

        public Nurse()
        {
        }

        public Nurse(string employeeName, int iDNumber, int salary, bool paid, string job) : base( employeeName,  iDNumber,  salary,  paid,  job)
        {
           NumberOfPatients = 100;

        }

        public override void DrawBlood()
        {
            //PatientBlood--;
        }

    }
}
