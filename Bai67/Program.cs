using System;
using System.Collections.Generic;

namespace Bai67
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> list = new List<Customer>();
            List<Hotel> hotels = new List<Hotel>();
            int choose;

            do
            {
                ShowMenu();
                choose = Int32.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                    case 6:

                        break;
                    case 7:
                        Console.WriteLine("Thoat!");
                        break;
                    default:
                        Console.WriteLine("Nhap sai! Nhap lai: ");
                        break;
                }
            } while (choose != 7);
        }

        static void InputHotel(List<Hotel> hotels)
        {
            Console.WriteLine("Nhap khach san: ");
            int n = int.Parse(Console.ReadLine());

            Hotel hotel = new Hotel();
            hotel.Input();
            hotels.Add(hotel);
        }
        static void InputCustomer(List<Customer> list)
        {
            Console.WriteLine("Nhap thong tin khach hang: ");
            Customer customer = new Customer();
            customer.Input();

            list.Add(customer);
        }
        static bool CheckIdNumber(List<Customer> list,string idnumber )
        {
            for(int i = 0;i < list.Count; i++)
            {
                if (list[i].IdNumber.Equals(idnumber)){ 
                return true;
                }
            }
            return false;
        }

        static bool CheckExistIdHotel(List<Hotel> hotels, int hotelid)
        {
            for (int i = 0; i < hotels.Count; i++)
            {
                if (hotels[i].HotelId.Equals(hotelid))
                {
                    return true;
                }
            }
            return false;
        }

        static void ShowMenu()
        {
            Console.WriteLine("1. Nhập thông tin khách sạn");
            Console.WriteLine("2. Hiển thị thông tin khách sạn");
            Console.WriteLine("3. Đặt phong nghỉ");
            Console.WriteLine("4. Tìm phòng còn trống");
            Console.WriteLine("5. Thống kê doanh duy khách sạn");
            Console.WriteLine("6. Tìm kiếm thông tin khách hàng.");
            Console.WriteLine("7. Thoát chương trình");
            Console.WriteLine("Choose: ");
        }
    }
}
