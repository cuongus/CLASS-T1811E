using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data.Common;

namespace BT575_2
{
    class DBUtils
    {
        public static List<MonHoc> getMonHoc(MySqlConnection conn)
        {
            List<MonHoc> MHList = new List<MonHoc>();
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("select * from mon_hoc", conn);
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        MonHoc monHoc = new MonHoc();
                        monHoc.MaMonHoc = reader.GetString(0);
                        monHoc.Ten = reader.GetString(1);

                        MHList.Add(monHoc);
                    }
                }
            }
            return MHList;
        }

        public static void addMonHoc(MySqlConnection conn, MonHoc monHoc)
        {
            MySqlCommand cmd = new MySqlCommand("insert into mon_hoc(ma, ten) values (" + monHoc.MaMonHoc + "," + monHoc.Ten + ")", conn);
            cmd.ExecuteNonQuery();
        }

        public static void editMonHoc(MySqlConnection conn, string ten, string ma)
        {
            MySqlCommand cmd = new MySqlCommand("update mon_hoc set ten =" + ten + "where ma =" + ma, conn);
            cmd.ExecuteNonQuery();
        }

        public static void deleteMonHoc(MySqlConnection conn, string ma)
        {
            MySqlCommand cmd = new MySqlCommand("delete mon_hoc where ma =" + ma, conn);
            cmd.ExecuteNonQuery();
        }



        public static List<SinhVien> getSinhVien(MySqlConnection conn)
        {
            List<SinhVien> SVList = new List<SinhVien>();
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("select * from sinh_vien", conn);
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        SinhVien sinhVien = new SinhVien();
                        sinhVien.MaSinhVien = reader.GetString(0);
                        sinhVien.Ten = reader.GetString(1);

                        SVList.Add(sinhVien);
                    }
                }
            }
            return SVList;
        }
        public static void addSinhVien(MySqlConnection conn, SinhVien sinhVien)
        {
            MySqlCommand cmd = new MySqlCommand("insert into sinh_vien(ma, ten) values (" + sinhVien.MaSinhVien + "," + sinhVien.Ten + ")", conn);
            cmd.ExecuteNonQuery();
        }

        public static void editSinhVien(MySqlConnection conn, string ten, string ma)
        {
            MySqlCommand cmd = new MySqlCommand("update sinh_vien set ten =" + ten + "where ma =" + ma, conn);
            cmd.ExecuteNonQuery();
        }

        public static void deleteSinhVien(MySqlConnection conn, string ma)
        {
            MySqlCommand cmd = new MySqlCommand("delete sinh_vien where ma =" + ma, conn);
            cmd.ExecuteNonQuery();
        }



        public static List<DiemThi> getDiemThi(MySqlConnection conn, string maMH, string maSV)
        {
            List<DiemThi> DTList = new List<DiemThi>();
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("select * from diem_thi where ma_mon_hoc=" + maMH + "and ma_sinh_vien=" + maSV, conn);
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DiemThi diemThi = new DiemThi();
                        diemThi.Diem = (int)reader.GetValue(0);
                        diemThi.MaMonHoc = maMH;
                        diemThi.MaSinhVien = maSV;

                        DTList.Add(diemThi);
                    }
                }
            }
            return DTList;
        }
        public static void addDiemThi(MySqlConnection conn, DiemThi diemThi, string maMH, string maSV)
        {
            MySqlCommand cmd = new MySqlCommand("insert into diem_thi(diem, ma_mon_hoc, ma_sinh_vien) values (" + diemThi.Diem + "," + maMH + "," + maSV + ")", conn);
            cmd.ExecuteNonQuery();
        }

        public static void editDiemThi(MySqlConnection conn, int diem, string maMH, string maSV)
        {
            MySqlCommand cmd = new MySqlCommand("update diem_thi set diem =" + diem + "where ma_mon_hoc =" + maMH + "and ma_sinh_vien=" + maSV, conn);
            cmd.ExecuteNonQuery();
        }

        public static void deleteDiemThi(MySqlConnection conn, string maMH, string maSV)
        {
            MySqlCommand cmd = new MySqlCommand("delete from diem_thi where ma_mon_hoc =" + maMH + "and ma_sinh_vien=" + maSV, conn);
            cmd.ExecuteNonQuery();
        }
    }
}
