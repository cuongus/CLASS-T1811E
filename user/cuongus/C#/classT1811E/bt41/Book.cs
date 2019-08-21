using System;
using System.Collections.Generic;
using System.Text;

namespace bt41
{
    class Book
    {
        public string TenSach { get; set; }
        public string NgayXB { get; set; }
        public string ButDanh { get; set; }
        public Book() { }
        public Book(string tenSach, string ngayXB, string butdanh)
        {
            TenSach = tenSach;
            NgayXB = ngayXB;
            ButDanh = butdanh;
        }

        public virtual void Input()
        {
            Console.WriteLine("Nhap ten cuon sach: ");
            TenSach = Console.ReadLine();
            Console.WriteLine("Nhap ngay XB: ");
            NgayXB = Console.ReadLine();
            Console.WriteLine("Nhap but danh: ");
            ButDanh = Console.ReadLine();
        }

        public virtual void Display()
        {
            Console.WriteLine("Ten CS: {0}, ngay XB: {1}, But danh: {2}.", TenSach, NgayXB, ButDanh);
        }
    }
}
