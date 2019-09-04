using System;
using System.Collections.Generic;
using System.Text;

namespace Bai67
{
    
    class Customer
    {
        public string IdNumber { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }

        public Customer()
        {

        }

        public Customer(string idNumber, string name, int age, string gender, string address)
        {
            this.IdNumber = idNumber;
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Address = address;
        }


        public void InputWithOutId()
        {
            Console.WriteLine("Nhap ten: ");
            Name = Console.ReadLine();
            Console.WriteLine("Nhap tuoi: ");
            Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap gioi tinh: ");
            Gender = Console.ReadLine();
            Console.WriteLine("Nhap dia chi: ");
            Address = Console.ReadLine();
        }
        public void Input()
        {
            Console.WriteLine("Nhap so chung minh thu: ");
            IdNumber = Console.ReadLine();
            InputWithOutId();
        }

        public void Display()
        {
            Console.WriteLine("Thong tin cua khach hang:\nSo CMT: {0}, Ten: {1}, Tuoi: {2}, Gioi tinh: {3}, Que quan: {4}", IdNumber, Name, Age, Gender, Address);
        }

         static bool CheckIdNumber(List<Customer> list,string idnumber)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].IdNumber.Equals(idnumber))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
