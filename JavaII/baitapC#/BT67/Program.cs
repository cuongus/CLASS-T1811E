using System;
using System.Collections.Generic;

namespace BT67
{
    class Program
    {
        static List<KhachHang> KhachHangs = new List<KhachHang>();
        static List<Hotel> Hotels = new List<Hotel>();
        static List<Book> Books = new List<Book>();
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
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Nhap lai!");
                        break;
                }
            } while (choose != 7);

        }

        static void option1()
        {
            Console.Write("Nhap so luong khach san: ");
            int n = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < Hotels.Count; i++)
            {
                Hotel hotel = new Hotel();
                hotel.input();

                Hotels.Add(hotel);
            }
        }

        static void option2()
        {
            foreach (Hotel hotel in Hotels)
            {
                hotel.display();
            }
        }

        static void option3()
        {
            Console.Write("Nhap so luong muon book: ");
            int n = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Book book = new Book();
                book.input(KhachHangs, Hotels);

                Books.Add(book);
            }
        }
        static void option4()
        {
            Console.Write("Nhap ngay muon dat: ");
            int checkIn = Int32.Parse(Console.ReadLine());
            Console.Write("Nhap ngay muon tra phong: ");
            int checkOut = Int32.Parse(Console.ReadLine());

            foreach (Book book in Books)
            {
                if (checkIn >= book.NgayCheckIn && checkOut <= book.NgayCheckOut)
                {
                    foreach (Hotel hotel in Hotels)
                    {
                        if (book.MaKS.Equals(hotel.MaKS))
                        {
                            foreach (Room room in hotel.Rooms)
                            {
                                room.display();
                            }
                        }
                    }
                }
            }
        }

        static void option5()
        {
            for (int i = 0; i < Hotels.Count; i++)
            {
                double total = Calculate(Hotels[i]);
                Console.WriteLine("Tong tien cua khach san {0}: {1}.", Hotels[i].Ten, total);
            }
        }

        static double Calculate(Hotel hotel)
        {
            double total = 0;
            for (int i = 0; i < Books.Count; i++)
            {
                if (Books[i].MaKS.Equals(hotel.MaKS))
                {
                    double price = GetMoney(hotel.Rooms, Books[i].MaPhong);
                    total += price * (Books[i].NgayCheckOut - Books[i].NgayCheckIn);
                }
            }
            return total;
        }

        static double GetMoney(List<Room> Rooms, string maPhong)
        {
            for (int i = 0; i < Rooms.Count; i++)
            {
                if (Rooms[i].MaPhong.Equals(maPhong))
                {
                    return Rooms[i].Gia;
                }
            }
            return 0;
        }
        static void option6()
        {
            Console.Write("Nhap so CMND khach hang: ");
            string search = Console.ReadLine();

            foreach (Book book in Books)
            {
                if (book.SoCMND.Equals(search))
                {
                    GetHotel(book.MaKS).display();
                }
            }
        }

        static Hotel GetHotel(string maKS)
        {
            for (int i = 0; i < Hotels.Count; i++)
            {
                if (Hotels[i].MaKS.Equals(maKS))
                {
                    return Hotels[i];
                }
            }
            return null;
        }

        static void menu()
        {
            Console.WriteLine("1. Nhap khach san.");
            Console.WriteLine("2. In khach san.");
            Console.WriteLine("3. Dat phong.");
            Console.WriteLine("4. Kiem tra cac phong dap ung yeu cau.");
            Console.WriteLine("5. In tong tien moi khach san.");
            Console.WriteLine("6. In tat ca khach hang bang khach hang.");
            Console.WriteLine("7. Thoat.");
            Console.WriteLine("Choose: ");
        }
    }
}
