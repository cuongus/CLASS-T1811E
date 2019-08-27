using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Bai68Phan2
{
    class Employee
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }

        public Employee()
        {

        }

        public Employee(string Name, string Gender, string Address, string Position, double Salary)
        {
            this.Name = Name;
            this.Gender = Gender;
            this.Address = Address;
            this.Position = Position;
            this.Salary = Salary;
        }

        public bool CheckGender(string Gender)
        {
            string gender1 = "Nam";
            string gender2 = "Nu";

            if (Gender.Equals(gender1) || Gender.Equals(gender2))
            {
                return false;
            }
            return true;
            
        }


        public void Input()
        {
            Console.WriteLine("Nhap ten: ");
            Name = Console.ReadLine();

            Console.WriteLine("Nhap gioi tinh (Nam hoac Nu): ");
            Gender = Console.ReadLine();
            while (true)
            {
                if (CheckGender(Gender))
                {
                    Gender = Console.ReadLine();
                    Console.WriteLine("Ban da nhap sai gioi tinh, moi ban nhap lai");
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("Nhap dia chi: ");
            Address = Console.ReadLine();

            Console.WriteLine("Nhap chuc vu: ");
            Position = Console.ReadLine();

            Console.WriteLine("Nhap luong: ");
            Salary = Double.Parse(Console.ReadLine());

        }

        public void ShowInfo()
        {
            Console.WriteLine("Thong tin nhan vien: ");
            Console.WriteLine("Ten: {0}, Gioi tinh: {1}, Dia chi: {2}, Chuc vu: {3}, Luong: {4}", Name, Gender, Address, Position, Salary);
        }

        static void Main(string[] args)
        {
            Employee nhanvien1 = new Employee();
            Employee nhanvien2 = new Employee("Nguyen Van A", "Nam","Ha Noi","Bao ve",10000000);

            nhanvien1.Input();

            nhanvien1.ShowInfo();
            nhanvien2.ShowInfo();


            Console.ReadKey();
        }
    }
}
