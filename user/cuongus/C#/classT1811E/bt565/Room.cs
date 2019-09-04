using System;
using System.Collections.Generic;
using System.Text;

namespace bt565
{
    [Serializable]
    class Room
    {
        public string TenPhong { get; set; }
        public int Tang { get; set; }
        public float Gia { get; set; }
        public int SoNguoi { get; set; }

        public Room() { }
        public Room(string tenPhong, int tang, float gia, int soNguoi)
        {
            TenPhong = tenPhong;
            Tang = tang;
            Gia = gia;
            SoNguoi = soNguoi;
        }

        public void Input()
        {
            Console.WriteLine("Nhap thong tin phong.");
            Console.WriteLine("Nhap ten phong: ");
            TenPhong = Console.ReadLine();
            Console.WriteLine("Nhap tang: ");
            Tang = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap gia: ");
            Gia = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so nguoi: ");
            SoNguoi = int.Parse(Console.ReadLine());

        }
        public void Display()
        {
            Console.WriteLine("Phong: {1}, Tang: {2}, Gia: {3}, So nguoi: {4}.", TenPhong, Tang, Gia, SoNguoi);
        }
    }
}
