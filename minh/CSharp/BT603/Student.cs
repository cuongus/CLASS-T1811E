using System;

namespace BT603
{
    class Student
    {
        string Name { get; set; }
        int Age { get; set; }
        public string StudentCode { get; set; }
        public string Address { get; set; }
        string Email { get; set; }
        string PhoneNumber { get; set; }
        public string ParentCode { get; set; }

        public Student() { }
        public Student(string parentCode)
        {
            this.ParentCode = parentCode;
        }
        public Student(string name, int age, string studentCode, string address, string email, string phoneNumber, string parentCode)
        {
            this.Name = name;
            this.Age = age;
            this.StudentCode = studentCode;
            this.Address = address;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            this.ParentCode = parentCode;
        }

        public void input()
        {
            Console.Write("Nhap ten:");
            Name = Console.ReadLine();
            Console.Write("Nhap tuoi:");
            Age = Int32.Parse(Console.ReadLine());
            Console.Write("Nhap ma sinh vien:");
            StudentCode = Console.ReadLine();
            Console.Write("Nhap dia chi:");
            Address = Console.ReadLine();
            Console.Write("Nhap Email:");
            Email = Console.ReadLine();
            Console.Write("Nhap so dien thoai:");
            PhoneNumber = Console.ReadLine();
        }

        public void display()
        {
            Console.WriteLine("Thong tin sinh vien: Ten: {0}, Tuoi: {1}, Ma sinh vien: {2}, Dia chi: {3}, Email: {4}, So dien thoai: {5}, Ma phu huynh: {6}", Name, Age, StudentCode, Address, Email, PhoneNumber, ParentCode);
        }
    }
}
