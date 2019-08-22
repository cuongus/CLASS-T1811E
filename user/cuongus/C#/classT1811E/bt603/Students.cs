using System;
using System.Collections.Generic;
using System.Text;

namespace bt603
{
    class Students
    {
        public string Fullname { get; set; }
        public int Age { get; set; }
        public int Scode { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Pcode { get; set; }

        public Students() { }

        public Students(string fullname, int age, int scode, string adress, string email, string phone, int pcode)
        {
            this.Fullname = fullname;
            this.Age = age;
            this.Scode = scode;
            this.Adress = adress;
            this.Email = email;
            this.Phone = phone;
            this.Pcode = pcode;
        }

        public void Input()
        {
            Console.WriteLine("Nhap ten sinh vien: ");
            Fullname = Console.ReadLine();
            Console.WriteLine("Nhap tuoi SV: ");
            Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ma SV: ");
            Scode = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap dia chi: ");
            Adress = Console.ReadLine();
            Console.WriteLine("Nhap Email: ");
            Email = Console.ReadLine();
            Console.WriteLine("Nhap SDT: ");
            Phone = Console.ReadLine();
            Console.WriteLine("Nhap ma PH: ");
            Pcode = int.Parse(Console.ReadLine());

            Console.WriteLine("-------------------------------------");
        }
        public void Display()
        {
            Console.WriteLine("Ten SV: {0}, tuoi SV: {1}, ma SV: {2}, dia chi: {3}, Email: {4}, SDT: {5}, ma PH: {6}", Fullname, Age, Scode, Adress, Email, Phone, Pcode);
        }
    }
}
