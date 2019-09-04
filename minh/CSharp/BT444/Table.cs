using System;

namespace Room
{
    class Table
    {
        string Ten { get; set; }
        string MauSac { get; set; }
        string NhaSanXuat { get; set; }
        float NgaySuDung { get; set; }

        public Table() { }
        public Table(string ten, string mauSac, string nhaSanXuat, float ngaySuDung)
        {
            Ten = ten;
            MauSac = mauSac;
            NhaSanXuat = nhaSanXuat;
            NgaySuDung = ngaySuDung;
        }

        public void input()
        {
            Console.Write("Nhap ten: ");
            Ten = Console.ReadLine();
            Console.Write("Nhap mau sac: ");
            MauSac = Console.ReadLine();
            Console.Write("Nhap nha san xuat: ");
            NhaSanXuat = Console.ReadLine();
            Console.Write("Nhap ngay su dung: ");
            NgaySuDung = float.Parse(Console.ReadLine());
        }

        public void display()
        {
            Console.WriteLine("Ten: " + Ten + ", Mau sac: " + MauSac + ", Nha san xuat: " + NhaSanXuat + ", So ngay su dung: " + NgaySuDung);
        }
    }
}
