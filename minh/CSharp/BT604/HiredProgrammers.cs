using System;
using System.Collections.Generic;
using System.Text;

namespace BT604
{
    class HiredProgrammers
    {
        private List<Programmer> HPGM = new List<Programmer>();

        public HiredProgrammers ()
        {
        }

        public void AddNew(List<Programmer> HPGM)
        {
            string skills = Console.ReadLine();
            DateTime dob = DateTime.Parse(Console.ReadLine());
            int id = Int32.Parse(Console.ReadLine());
            string name = Console.ReadLine();

            Programmer programmer = new Programmer(id, name, skills, dob);
            HPGM.Add(programmer);
        }

        public int ShowFilterInfo(int underage, List<Programmer> HPGM)
        {
            int count=0;
            Console.Write("Input underage: ");
            underage = Int32.Parse(Console.ReadLine());
            foreach(Programmer pgrm in HPGM)
            {
                if(underage >= pgrm.Age)
                {
                    pgrm.ShowInfo();
                    count++;
                }
            }
            return count;
        }
    }
}
