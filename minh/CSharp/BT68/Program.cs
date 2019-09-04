using BTVN.BT68;
using System;

namespace BT68
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.input();
            Employee employee2 = new Employee("Nguyen Thi B", "Nu", "Ho Chi Minh", "Ke Toan", 2000);

            employee1.display();
            employee2.display();
        }
    }
}
