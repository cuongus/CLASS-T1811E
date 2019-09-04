using System;
using System.Collections.Generic;
using System.Text;

namespace Bai67
{

    public class Customer
    {
        public string CMND { get; set; }
        public string Fullname { get; set; }
        public int Old { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }


        public Customer()
        {
        }

        public void Input()
        {
            Console.WriteLine("Nhap CMND : ");
            CMND = Console.ReadLine();

            Console.WriteLine("Nhap Ho & Ten : ");
            Fullname = Console.ReadLine();

            Console.WriteLine("Nhap Tuoi : ");
            Old = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Nhap Gioi Tinh : ");
            Gender = Console.ReadLine();

            Console.WriteLine("Nhap Dia Chi : ");
            Address = Console.ReadLine();

        }

        public void Display()
        {
            Console.WriteLine("Thong tin KH(Ho Ten : {0}, Tuoi : {1}, CMND : {2}, Gioi Tinh : {3}, Dia Chi : {4})", Fullname, Old, Gender, CMND, Address);
        }
    }   
}
