using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryHospital
{
    public class Doctor : Employees
    {

        public string Specialty { get; set; }


        public Doctor() : base("Jim",0001,20000,false)
        {
            Specialty = "hand"; 
        }

        public void DrawBloodDoctor()
        {
           int PatientBlood = 20;
           PatientBlood--;

           int PatientsHealth = 10;
           PatientsHealth++;
            
        }
    }
}
