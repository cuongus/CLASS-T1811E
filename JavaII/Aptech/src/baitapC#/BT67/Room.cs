using System;

namespace BT67
{
    class Room
    {
        public string Ten { get; set; }
        public int Tang { get; set; }
        public double Gia { get; set; }
        public int ToiDa { get; set; }
        public string MaPhong { get; set; }

        public Room() { }
        public Room(string ten, int tang, double gia, int toiDa, string maPhong)
        {
            this.Ten = ten;
            this.Tang = tang;
            this.Gia = gia;
            this.ToiDa = toiDa;
            this.MaPhong = MaPhong;
        }

        public void input()
        {
            Console.Write("Nhap ten phong: ");
            Ten = Console.ReadLine();
            Console.Write("Nhap tang: ");
            Tang = Int32.Parse(Console.ReadLine());
            Console.Write("Nhap gia: ");
            Gia = Double.Parse(Console.ReadLine());
            Console.Write("Nhap so nguoi toi da: ");
            ToiDa = Int32.Parse(Console.ReadLine());
            Console.Write("Nhap ma phong: ");
            MaPhong = Console.ReadLine();
        }

        public void display()
        {
            Console.WriteLine("Thong tin phong: Ten: {0}, Tang: {1}, Gia: {2}, So nguoi toi da: {3}, Ma phong: {4}.", Ten, Tang, Gia, ToiDa, MaPhong);
        }
    }
}
