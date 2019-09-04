using System;

namespace BT67
{
    class KhachHang
    {
        public string SoCMND { get; set; }
        public string HoTen { get; set; }
        public int Tuoi { get; set; }
        public string GioiTinh { get; set; }
        public string QueQuan { get; set; }

        public KhachHang() { }
        public KhachHang(string soCMND, string hoTen, int tuoi, string gioiTinh, string queQuan)
        {
            this.SoCMND = soCMND;
            this.HoTen = hoTen;
            this.Tuoi = tuoi;
            this.GioiTinh = gioiTinh;
            this.QueQuan = queQuan;
        }

        public void input(string soCMND)
        {
            Console.Write("Nhap ho va ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap tuoi: ");
            Tuoi = Int32.Parse(Console.ReadLine());
            Console.Write("Nhap gioi tinh: ");
            GioiTinh = Console.ReadLine();
            Console.Write("Nhap que quan: ");
            QueQuan = Console.ReadLine();
        }
        public void input()
        {
            Console.Write("Nhap so CMND: ");
            SoCMND = Console.ReadLine();
            Console.Write("Nhap ho va ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap tuoi: ");
            Tuoi = Int32.Parse(Console.ReadLine());
            Console.Write("Nhap gioi tinh: ");
            GioiTinh = Console.ReadLine();
            Console.Write("Nhap que quan: ");
            QueQuan = Console.ReadLine();
        }

        public void display()
        {
            Console.WriteLine("Thong tin khach hang: CMND: {0}, Ten: {1}, Tuoi: {2}, Gioi tinh: {3}, Que quan: {4}.", SoCMND, HoTen, Tuoi, GioiTinh, QueQuan);
        }
    }
}
