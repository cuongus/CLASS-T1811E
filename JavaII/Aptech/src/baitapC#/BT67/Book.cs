using System;
using System.Collections.Generic;

namespace BT67
{
    class Book
    {
        public int NgayCheckIn { get; set; }
        public int NgayCheckOut { get; set; }
        public string SoCMND { get; set; }
        public string MaKS { get; set; }
        public string MaPhong { get; set; }

        public Book() { }

        public void input(List<KhachHang> KhachHangs, List<Hotel> Hotels)
        {
            // nhap cmnd
            Console.Write("Nhap CMNT khach hang: ");
            SoCMND = Console.ReadLine();
            bool find = false;
            for (int i = 0; i < KhachHangs.Count; i++)
            {
                if (KhachHangs[i].SoCMND.Equals(SoCMND))
                {
                    find = true;
                    break;
                }
            }

            if (!find)
            {
                Console.WriteLine("Khach hang chua ton tai!");
                KhachHang khachHang = new KhachHang();
                khachHang.input(SoCMND);

                KhachHangs.Add(khachHang);
            }

            // nhap khach san
            HotelMenu(Hotels);
            Console.Write("Nhap ma khach san: ");
            while (true)
            {
                MaKS = Console.ReadLine();
                bool find1 = false;
                for (int i = 0; i < Hotels.Count; i++)
                {
                    if (Hotels[i].MaKS.Equals(MaKS))
                    {
                        find1 = true;
                        break;
                    }
                }
                if (!find1)
                {
                    Console.Write("Nhap lai ma KS: ");
                }
                else
                {
                    break;
                }
            }

            // nhap ma phong
            Hotel hotelCache = null;
            for (int i = 0; i < Hotels.Count; i++)
            {
                if (Hotels[i].MaKS.Equals(MaKS))
                {
                    RoomMenu(Hotels[i]);
                    hotelCache = Hotels[i];
                }
            }
            Console.Write("Nhap ma phong: ");
            while(true)
            {
                MaPhong = Console.ReadLine();
                bool find2 = false;
                for(int i=0; i<hotelCache.Rooms.Count; i++)
                {
                    if(hotelCache.Rooms[i].MaPhong.Equals(MaPhong))
                    {
                        find2 = true;
                        break;
                    }
                }
                if(!find2)
                {
                    Console.Write("Nhap lai ma phong: ");
                } else
                {
                    break;
                }
            }


            Console.Write("Nhap ngay dat phong: ");
            NgayCheckIn = Int32.Parse(Console.ReadLine());
            Console.Write("Nhap ngay tra phong: ");
            NgayCheckOut = Int32.Parse(Console.ReadLine());
        }

        public void HotelMenu(List<Hotel> Hotels)
        {
            Console.WriteLine("Danh sach khach san: ");
            for (int i = 0; i < Hotels.Count; i++)
            {
                Console.WriteLine("{0}. {1}: {2}", i + 1, Hotels[i].Ten, Hotels[i].MaKS);
            }
        }

        public void RoomMenu(Hotel hotel)
        {
            Console.WriteLine("Danh sach phong: ");
            for (int i = 0; i < hotel.Rooms.Count; i++)
            {
                Console.WriteLine("{0}. {1}: {2}", i + 1, hotel.Rooms[i].Ten, hotel.Rooms[i].MaPhong);
            }
        }
    }
}
