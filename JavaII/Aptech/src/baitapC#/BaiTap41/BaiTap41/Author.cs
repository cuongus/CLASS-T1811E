using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap41
{
    public class Author
    {
        public string Fullname { get; private set; }
        public string Birtday { get; private set; }
        public string Nickname { get; private set; }
        public string Address { get; private set; }

        public Author()
        {
        }

        public Author(string fullname, string birtday, string nickname, string address)
        {
            this.Fullname = fullname;
            this.Birtday = birtday;
            this.Nickname = nickname;
            this.Address = address;
        }

        public void Input()
        {
            Console.WriteLine("Nhap ten tac gia: ");
            Fullname = Console.ReadLine();

            Console.WriteLine("Nhap ngay sinh: ");
            Birtday = Console.ReadLine();

            Console.WriteLine("Nhap but danh: ");
            Nickname = Console.ReadLine();

            Console.WriteLine("Nhap dia chi: ");
            Address = Console.ReadLine();
        }

        public void Display()
        {
            Console.WriteLine("Thong tin tac gia(Ho ten : {0}, Ngay sinh : {1}, But danh : {2}, Dia chi : {3})", Fullname, Birtday, Nickname, Address);
        }
    }
}
