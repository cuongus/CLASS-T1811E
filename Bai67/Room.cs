using System;
using System.Collections.Generic;
using System.Text;

namespace Bai67
{
    public class Room
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int FloorNo { get; set; }
        public int MaxPeople { get; set; }
        public string RoomId { get; set; }

        public Room()
        {

        }

        public Room(string name,int price, int floorNo, int maxPeople, string roomId)
        {
            this.Name = name;
            this.Price = price;
            this.FloorNo = floorNo;
            this.MaxPeople = maxPeople;
            this.RoomId = roomId;
        }

        public void Input()
        {
            Console.WriteLine("Nhap ten phong: ");
            Name = Console.ReadLine();
            Console.WriteLine("Nhap gia phong: ");
            Price = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap tang cua phong: ");
            FloorNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so nguoi toi da: ");
            MaxPeople = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ma phong: ");
            RoomId = Console.ReadLine();

        }

        public void Display()
        {
            Console.WriteLine("Thong tin cua phong:\nTen phong: {0}, Gia phong: {1}, Tang cua phong: {2}, So nguoi toi da: {3}, Ma phong: {4}", Name, Price, FloorNo, MaxPeople, RoomId);
        }
    }
}