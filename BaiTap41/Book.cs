using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap41
{
    class Book
    {
        public string Name { get; set; }
        public string ReleaseDate { get; set; }
        public string NickName { get; set; }

        public Book()
        {

        }

        public Book(string Name, string ReleaseDate, string NickName)
        {
            this.Name = Name;
            this.ReleaseDate = ReleaseDate;
            this.NickName = NickName;
        }

        public void Input()
        {
            Console.WriteLine("Nhap ten sach: ");
            Name = Console.ReadLine();
            Console.WriteLine("Nhap ngay xuat ban: ");
            ReleaseDate = Console.ReadLine();
            Console.WriteLine("Nhap but danh: ");
            NickName = Console.ReadLine();
        }

        public void Display()
        {
            Console.WriteLine("Thong tin sach (Ten sach: {0}, Ngay xuat ban: {1}, But danh: {2})", Name, ReleaseDate, NickName);
        }
    }
}
