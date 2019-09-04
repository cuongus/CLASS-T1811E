using System;
using System.Collections.Generic;
using System.Text;

namespace Bai67
{
    class Hotel
    {
        public string HotelName { get; set; }
        public string HotelAddress { get; set; }
        public string HotelRate { get; set; }
        public List<Room> roomList = new List<Room>();
        public int HotelId { get; set; }

        public Hotel()
        {

        }

        public Hotel(string hotelName, string hotelAddres, string hotelRate, int hotelRoom, int hotelId)
        {
            this.HotelName = hotelName;
            this.HotelAddress = hotelAddres;
            this.HotelRate = hotelRate;
            this.HotelId = hotelId;
        }

        public void Input()
        {
            Console.WriteLine("Nhap ten khach san: ");
            HotelName = Console.ReadLine();
            Console.WriteLine("Nhap dia chi khach san: ");
            HotelAddress = Console.ReadLine();
            Console.WriteLine("Nhap loai khach san: ");
            HotelRate = Console.ReadLine();

            Console.WriteLine("Nhap ma khach san: ");
            HotelId = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap so phong can them: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Room room = new Room();
                room.Input();

                roomList.Add(room);
            }
        }

        public void Display()
        {
            Console.WriteLine("Thong tin khach san:\nTen khach san: {0}, Dia chi khach san: {1}, Loai khach san: {2}, Ma khach san: {3}",HotelName,HotelAddress,HotelRate,HotelId);
            for(int i = 0; i < roomList.Count; i++)
            {
                roomList[i].Display();
            }
        }

        static bool CheckExistIdHotel(List<Hotel> hotels,int hotelid)
        {
            for(int i = 0; i < hotels.Count; i++)
            {
                if (hotels[i].HotelId.Equals(hotelid))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
