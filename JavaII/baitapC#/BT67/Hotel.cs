using System;
using System.Collections.Generic;

namespace BT67
{
    [Serializable]
    class Hotel
    {
        public string Ten { get; set; }
        public string DiaChi { get; set; }
        public string LoaiKS { get; set; }
        public string MaKS { get; set; }

        public List<Room> Rooms = new List<Room>();

        public Hotel() { }
        public Hotel(string maKS)
        {
            this.MaKS = maKS;
        }
        public Hotel(string ten, string diaChi, string loaiKS, string maKS, List<Room> rooms)
        {
            this.Ten = ten;
            this.DiaChi = diaChi;
            this.LoaiKS = loaiKS;
            this.MaKS = maKS;
            this.Rooms = rooms;
        }

        public void input()
        {
            Console.Write("Nhap ten khach san: ");
            Ten = Console.ReadLine();
            Console.Write("Nhap dia chi khach san: ");
            DiaChi = Console.ReadLine();
            Console.Write("Nhap loai khach san: ");
            LoaiKS = Console.ReadLine();
            Console.Write("Nhap ma khach san: ");
            MaKS = Console.ReadLine();
            Console.Write("Nhap so phong muon them: ");
            int n = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Room room = new Room();
                room.input();

                Rooms.Add(room);
            }
        }

        public void display()
        {
            Console.WriteLine("Thong tin khach san: Ten: {0}, Dia chi: {1}, Loai: {2}, Ma khach san: {3}.", Ten, DiaChi, LoaiKS, MaKS);
            foreach (Room room in Rooms)
            {
                Console.Write("---");
                room.display();
            }
        }
    }
}
