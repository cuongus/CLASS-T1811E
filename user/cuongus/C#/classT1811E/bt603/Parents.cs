using System;
using System.Collections.Generic;
using System.Text;

namespace bt603
{
    class Parents
    {
        public string Fullname { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public int Pcode { get; set; }

        public Parents() { }
        public Parents(string fullname, string adress, string phone, int pcode)
        {
            Fullname = fullname;
            Adress = adress;
            Phone = phone;
            Pcode = pcode;
        }

        public void Input()
        {
            Console.WriteLine("Nhap ten phu huynh: ");
            Fullname = Console.ReadLine();
            Console.WriteLine("Nhap dia chi: ");
            Adress = Console.ReadLine();
            Console.WriteLine("Nhap so dien thoai: ");
            Phone = Console.ReadLine();
            Console.WriteLine("Nhap ma phu huynh: ");
            Pcode = int.Parse(Console.ReadLine());

            Console.WriteLine("-------------------------------------");
        }

        public void Display()
        {
            Console.WriteLine("Ten PH: {0}, dia chi: {1}, SDT: {2}, ma PH: {3}", Fullname, Adress, Phone, Pcode);
        }
    }
}
