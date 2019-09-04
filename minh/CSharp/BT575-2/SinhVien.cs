using System;

namespace BT575_2
{
    class SinhVien
    {
        public string Ten { get; set; }
        public string MaSinhVien { get; set; }

        public SinhVien() { }
        public SinhVien(string ten, string maSinhVien)
        {
            this.Ten = ten;
            this.MaSinhVien = maSinhVien;
        }

        public void input()
        {
            Console.Write("Nhap ten: ");
            Ten = Console.ReadLine();
            Console.Write("Nhap ma: ");
            MaSinhVien = Console.ReadLine();
        }

        public void display()
        {
            Console.WriteLine("Thong tin sinh vien: Ten: {0}, Ma: {1}", Ten, MaSinhVien);
        }
    }
}
