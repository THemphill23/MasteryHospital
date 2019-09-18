using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryHospital
{
    class Nurse : Employees
    {

        public int NumberOfPatients { get; set; }


        public Nurse() : base("Janet", 0002, 10000, false)
        {
            NumberOfPatients = 100;
        }

        public void DrawBloodNurse()
        {
            int PatientBlood = 20;
            PatientBlood--;

            int PatientsHealth = 10;
            PatientsHealth++;

        }
    }
}
