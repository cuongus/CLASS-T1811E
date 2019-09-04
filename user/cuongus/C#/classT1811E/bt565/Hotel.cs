using System;
using System.Collections.Generic;
using System.Text;

namespace bt565
{
    [Serializable]
    class Hotel
    {
        public string TenKS { get; set; }
        public string DiaChi { get; set; }
        public string DanhSachPhong { get; set; }

        public Hotel() { }
        public Hotel(string tenKS, string diachi, string danhsachPhong)
        {
            TenKS = tenKS;
            DiaChi = diachi;
            DanhSachPhong = danhsachPhong;
        }

        public void Input()
        {
            Console.WriteLine("Nhap thong tin khach san:");
            Console.WriteLine("Nhap Ten Khach san: ");
            TenKS = Console.ReadLine();
            Console.WriteLine("Nhap dia chi khach san: ");
            DiaChi = Console.ReadLine();
            Console.WriteLine("Nhap danh sach phong: ");
            DanhSachPhong = Console.ReadLine();

        }
        public void Display()
        {
            Console.WriteLine("Khach San: {1}, Dia chi: {2}, Danh sach phong: {3}.", TenKS, DiaChi, DanhSachPhong);
        }
    }
}
