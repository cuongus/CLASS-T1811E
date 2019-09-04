using System;
using System.Collections.Generic;

namespace BT565
{
    [Serializable]
    class Hotel
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public List<Room> roomList = new List<Room>();

        public Hotel() { }
        public Hotel(string name, string address)
        {
            this.Name = name;
            this.Address = address;
        }

        public void input()
        {
            Console.Write("Nhap ten khach san: ");
            Name = Console.ReadLine();
            Console.Write("Nhap dia chi khach san: ");
            Address = Console.ReadLine();
            Console.Write("Nhap so phong muon them: ");
            int n = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Room room = new Room();
                room.input();

                roomList.Add(room);
            }
        }

        public void display()
        {
            Console.WriteLine("Thong tin khach san: Ten: {0}, Dia chi: {1}.", Name, Address);
            foreach (Room room in roomList)
            {
                Console.Write("---");
                room.display();
            }
        }
    }
}
