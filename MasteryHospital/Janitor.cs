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

        public Janitor(string employeeName, int IDNumber, int Salary, bool Paid, bool Sweeping) : base("George Festits", 0035, 0001, false, true)
        {
            Sweeping = true;
        }




        //List

        public List<Janitor> janitorList = new List<Janitor>();



        //Methods

        //Add To List


        public void AddJanitorToJanitorList()
        {

            janitorList.Add(new Janitor("Myles Power", 0035, 0001, false, true));
            janitorList.Add(new Janitor("Teeth O'Brian", 0039, 0001, false, true));

        }
    }
}
