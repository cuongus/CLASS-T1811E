using System;

namespace BT575_2
{
    class MonHoc
    {
        public string Ten { get; set; }
        public string MaMonHoc { get; set; }

        public MonHoc() { }
        public MonHoc(string ten, string maMonHoc)
        {
            this.Ten = ten;
            this.MaMonHoc = maMonHoc;
        }

        public void input()
        {
            Console.Write("Nhap ten: ");
            Ten = Console.ReadLine();
            Console.Write("Nhap ma: ");
            MaMonHoc = Console.ReadLine();
        }

        public void display()
        {
            Console.WriteLine("Thong tin mon hoc: Ten: {0}, Ma: {1}", Ten, MaMonHoc);
        }
    }
}
