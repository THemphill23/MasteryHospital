using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MasteryHospital
{
    public class Doctor : Employee
    {

        public string Specialty { get; set; }
    
        public Doctor()
        {
        }

        public Doctor(string employeeName, int iDNumber, int salary, bool paid, string speciality) : base( employeeName,  iDNumber,  salary,  paid,  speciality)
        {
            speciality = "hand";
        }


        public override void DrawBlood()
        {
            //PatientBlood--;
        }


    }
}

