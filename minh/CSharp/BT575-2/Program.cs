using ConnectMySql;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace BT575_2
{
    class Program
    {

        static void Main(string[] args)
        {
            int choose;
            do
            {
                menu();
                choose = Int32.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        option1();
                        break;
                    case 2:
                        option2();
                        break;
                    case 3:
                        option3();
                        break;
                    case 4:
                        option4();
                        break;
                    case 5:
                        option5();
                        break;
                    case 6:
                        option6();
                        break;
                    case 7:
                        option7();
                        break;
                    case 8:
                        option8();
                        break;
                    case 9:
                        option9();
                        break;
                    case 10:
                        Console.WriteLine("Goodbye.");
                        break;
                    default:
                        Console.WriteLine("Wrong choose.");
                        break;
                }

            } while (choose != 10);

        }

        static void option1()
        {
            MonHoc monHoc = new MonHoc();
            monHoc.input();
            MySqlConnection conn = null;

            try
            {
                conn = DBConnect.getConnection();
                DBUtils.addMonHoc(conn, monHoc);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
        }

        static void option2()
        {
            string maMH, tenMH;
            MySqlConnection conn = null;
            try
            {
                conn = DBConnect.getConnection();
                foreach (MonHoc monHoc in DBUtils.getMonHoc(conn))
                {
                    monHoc.display();
                }
                Console.Write("Nhap ma mon hoc muon sua: ");
                maMH = Console.ReadLine();
                Console.Write("Sua ten thanh: ");
                tenMH = Console.ReadLine();

                DBUtils.editMonHoc(conn, tenMH, maMH);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
        }

        static void option3()
        {
            string maMH;
            MySqlConnection conn = null;
            try
            {
                conn = DBConnect.getConnection();
                foreach (MonHoc monHoc in DBUtils.getMonHoc(conn))
                {
                    monHoc.display();
                }
                Console.Write("Nhap ma mon hoc muon xoa: ");
                maMH = Console.ReadLine();

                DBUtils.deleteMonHoc(conn, maMH);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
        }

        static void option4()
        {
            SinhVien sinhVien = new SinhVien();
            sinhVien.input();
            MySqlConnection conn = null;

            try
            {
                conn = DBConnect.getConnection();
                DBUtils.addSinhVien(conn, sinhVien);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
        }

        static void option5()
        {
            string maSV, tenSV;
            MySqlConnection conn = null;
            try
            {
                conn = DBConnect.getConnection();
                foreach (SinhVien sinhVien in DBUtils.getSinhVien(conn))
                {
                    sinhVien.display();
                }
                Console.Write("Nhap ma sinh vien muon sua: ");
                maSV = Console.ReadLine();
                Console.Write("Sua ten thanh: ");
                tenSV = Console.ReadLine();

                DBUtils.editSinhVien(conn, tenSV, maSV);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
        }

        static void option6()
        {
            string maSV;
            MySqlConnection conn = null;
            try
            {
                conn = DBConnect.getConnection();
                foreach (SinhVien sinhVien in DBUtils.getSinhVien(conn))
                {
                    sinhVien.display();
                }
                Console.Write("Nhap ma sinh vien muon xoa: ");
                maSV = Console.ReadLine();

                DBUtils.deleteSinhVien(conn, maSV);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
        }

        static void option7()
        {
            string maSV, maMH;
            DiemThi diemThi = new DiemThi();
            MySqlConnection conn = null;
            try
            {
                conn = DBConnect.getConnection();
                foreach (MonHoc monHoc in DBUtils.getMonHoc(conn))
                {
                    monHoc.display();
                }
                foreach (SinhVien sinhVien in DBUtils.getSinhVien(conn))
                {
                    sinhVien.display();
                }

                Console.Write("Nhap ma mon hoc muon them diem: ");
                maMH = Console.ReadLine();
                Console.Write("Nhap ma sinh vien muon them diem: ");
                maSV = Console.ReadLine();

                DBUtils.addDiemThi(conn, diemThi, maMH, maSV);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
        }

        static void option8()
        {
            List<DiemThi> DTList = new List<DiemThi>();
            string maSV, maMH;
            MySqlConnection conn = null;
            try
            {
                conn = DBConnect.getConnection();

                foreach (SinhVien sinhVien in DBUtils.getSinhVien(conn))
                {
                    foreach (MonHoc monHoc in DBUtils.getMonHoc(conn))
                    {
                        DTList = DBUtils.getDiemThi(conn, monHoc.MaMonHoc, sinhVien.MaSinhVien);
                    }
                }

                foreach (DiemThi diemThi in DTList)
                {
                    diemThi.display();
                }

                Console.Write("Nhap ma sinh vien muon sua: ");
                maSV = Console.ReadLine();
                Console.Write("Nhap ma mon hoc muon sua: ");
                maMH = Console.ReadLine();
                Console.Write("Nhap diem muon sua: ");
                int diem = Int32.Parse(Console.ReadLine());

                DBUtils.editDiemThi(conn, diem, maMH, maSV);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
        }

        static void option9()
        {

        }

        static void menu()
        {
            Console.WriteLine("1. Them mon hoc.");
            Console.WriteLine("2. Sua mon hoc.");
            Console.WriteLine("3. Xoa mon hoc.");
            Console.WriteLine("4. Them sinh vien.");
            Console.WriteLine("5. Sua sinh vien.");
            Console.WriteLine("6. Xoa sinh vien.");
            Console.WriteLine("7. Them diem thi.");
            Console.WriteLine("8. Sua diem thi.");
            Console.WriteLine("9. Xoa diem thi.");
            Console.WriteLine("10. Thoat.");
            Console.WriteLine("Choose: ");
        }
    }
}
