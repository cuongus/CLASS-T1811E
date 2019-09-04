using System;
using System.Collections.Generic;
using System.Text;

namespace Bai67
{

    public class Hotel
    {

        public string Name { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }
        public List<Room> roomList = new List<Room>();

        public Hotel()
        {
        }

        public void Input()
        {
            Console.WriteLine("Nhap ten khach san : ");
            Name = Console.ReadLine();

            Console.WriteLine("Nhap dia chi : ");
            Address = Console.ReadLine();

            Console.WriteLine("Nhap loai khach san : ");
            Type = Console.ReadLine();

            Console.WriteLine("Nhap so phong can them : ");
            int N = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Room room = new Room();
                room.Input();

                roomList.Add(room);
            }
        }

        public void Display()
        {
            Console.WriteLine("Hotel (Ten KS : {0}, Gia : {1}, Tang : {2}, So nguoi toi da : {3}, Ma phong : {4 })", Name, Price, Floor, PersonalMax, No);
        }


    }
}
