using System;

namespace BT575_2
{
    class DiemThi
    {
        public int Diem { get; set; }
        public string MaMonHoc { get; set; }
        public string MaSinhVien { get; set; }
        public DiemThi() { }
        public DiemThi(int diem, string maMonHoc, string maSinhVien)
        {
            this.Diem = diem;
            this.MaMonHoc = maMonHoc;
            this.MaSinhVien = maSinhVien;
        }

        public void display()
        {
            Console.WriteLine("Thong tin diem thi: Ma sinh vien: {0}, Ma mon hoc: {1}, Diem: {2}", MaSinhVien, MaMonHoc, Diem);
        }
    }
}
