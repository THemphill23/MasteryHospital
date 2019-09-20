using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryHospital
{
    class Receptionist : Employee
    {
        public bool Talking { get; set; }

        public Receptionist(string employeeName, int IDNumber, int Salary, bool Paid, bool Talking) : base("Michelle Maximus", 0035, 0001, false, false)
        {
            Talking = true;
        }

        public Receptionist()
        {
        }



        //List

        public List<Receptionist> receptionistList = new List<Receptionist>();



        //Methods

        //Add To List


        public void AddReceptionistToReceptiionistList()
        {

            receptionistList.Add(new Receptionist("Brandy Best", 0035, 0001, false, false));
            receptionistList.Add(new Receptionist("Thomas Trust", 0039, 0001, false, false));
            receptionistList.Add(new Receptionist("Ryan Lopeda", 0042, 0001, false, false));

        }
    }
}
