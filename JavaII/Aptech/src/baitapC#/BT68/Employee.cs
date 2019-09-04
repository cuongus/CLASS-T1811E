using System;

namespace BTVN.BT68
{
    class Employee
    {
        public string Fullname { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Job { get; set; }
        public double Salary { get; set; }

        public Employee()
        {
        }

        public Employee(string fullname, string gender, string address, string job, double salary)
        {
            Fullname = fullname;
            Gender = gender;
            Address = address;
            Job = job;
            Salary = salary;
        }

        public void input()
        {
            Console.Write("Nhap ten: ");
            Fullname = Console.ReadLine();
            Console.Write("Nhap gioi tinh: ");
            Gender = Console.ReadLine();
            Console.Write("Nhap que quan: ");
            Address = Console.ReadLine();
            Console.Write("Nhap chuc vu: ");
            Job = Console.ReadLine();
            Console.Write("Nhap luong: ");
            Salary = double.Parse(Console.ReadLine());
        }

        public void display()
        {
            Console.WriteLine("Name: " + Fullname + ", Gender: " + Gender + ", Address: " + Address + ", Job: " + Job + ", Salary: " + Salary);
        }

    }
}
