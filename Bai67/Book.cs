using System;
using System.Collections.Generic;
using System.Text;

namespace Bai67
{
    class Book
    {
        public string BookDate { get; set; }
        public string CheckOutDate { get; set; }
        public string IdNumber { get; set; }
        public int HotelId { get; set; }
        public int RoomId { get; set; }

        public Book()
        {

        }

        public Book(string bookDate, string checkoutDate, string idNumber, int hotelId, int roomId)
        {
            this.BookDate = bookDate;
            this.CheckOutDate = checkoutDate;
            this.IdNumber = idNumber;
            this.HotelId = hotelId;
            this.RoomId = roomId;
        }

        

        public void Input(List<Customer> list, List<Hotel> hotels)
        {
            Console.WriteLine("Nhap chung minh tu nhan dan cua khach hang: ");
            IdNumber = Console.ReadLine();

            //kiem tra thong tin khach hang
            bool isFind = false;
            for(int i = 0; i < list.Count; i++)
            {
                if (list[i].IdNumber.Equals(IdNumber))
                {
                    isFind = true;
                    break;
                }
            }

            //them moi khach hang
            if (!isFind)
            {
                Console.WriteLine("Khach hang chua ton tai >> nhap moi: ");
                Customer customer = new Customer();
                customer.IdNumber = IdNumber;
                customer.InputWithOutId();

                list.Add(customer);
            }

            DisplayHotelMenu(hotels);
            Hotel hotel = null;
            while (true)
            {
                string HotelNo = Console.ReadLine();
                isFind = false;
                for (int i = 0; i < hotels.Count; i++)
                {
                    if (hotels[i].HotelId.Equals(HotelNo)) {
                        isFind = true;
                        hotel = hotels[i];
                        break;
                    };

                }
                if (isFind)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Nhap lai ma khach san: ");
                }
            }

            //nhap ma phong
            DisplayRoomHotel(hotel);
            while (true)
            {
                RoomId = int.Parse(Console.ReadLine());
                isFind = false;
                for (int i = 0; i < hotel.roomList.Count; i++)
                {
                    if (hotel.roomList[i].RoomId.Equals(RoomId))
                    {
                        isFind = true;
                        hotel = hotels[i];
                        break;
                    };

                }
                if (isFind)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Nhap lai ma phong: ");
                }
            }

            //nhap ngay dat phong va ngay tra
            Console.WriteLine("Nhap ngay dat phong: ");
            BookDate = Console.ReadLine();

            Console.WriteLine("Nhap ngay tra phong: ");
            CheckOutDate = Console.ReadLine();
        }

        public void DisplayHotelMenu(List<Hotel> hotels)
        {
            for(int i = 0; i < hotels.Count; i++)
            {
                Console.WriteLine("{0}. {1} - {2} ", i + 1, hotels[i].HotelName, hotels[i].HotelId);
            }
            Console.WriteLine("Nhap ma khach san can chon: ");
            
        }

        public void DisplayRoomHotel(Hotel hotel)
        {
            for (int i = 0; i < hotel.roomList.Count; i++)
            {
                Console.WriteLine("{0}. {1} - {2} ", i + 1, hotel.roomList[i].Name, hotel.roomList[i].RoomId);
            }
            Console.WriteLine("Nhap ma phong can chon: ");
        }


    }
}
