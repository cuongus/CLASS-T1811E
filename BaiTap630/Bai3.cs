using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap630
{
    class Bai3
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap ten cua ban: ");
            string name = Console.ReadLine();
            Console.WriteLine("Ten cua ban la: " + name);
            Console.Write("Nhap tuoi cua ban: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Tuoi cua ban la: " + age);
            Console.Write("Nhap dia chi cua ban : ");
            string address = Console.ReadLine();
            Console.WriteLine("Dia chi cua ban la: " + address);
            Console.Write("Nhap ma sinh vien cua ban: ");
            int masv = int.Parse(Console.ReadLine());
            Console.WriteLine("Ma sinh vien cua ban la: " + masv);

            Console.ReadKey();
        }
    }
}
