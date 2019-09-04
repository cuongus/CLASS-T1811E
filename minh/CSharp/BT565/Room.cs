using System;

namespace BT565
{
    class Room
    {
        public string Name { get; set; }
        public int Floor { get; set; }
        public double Price { get; set; }
        public int MaxCustomer { get; set; }

        public Room() { }
        public Room(string name, int floor, double price, int maxCustomer)
        {
            this.Name = name;
            this.Floor = floor;
            this.Price = price;
            this.MaxCustomer = maxCustomer;
        }

        public void input()
        {
            Console.Write("Nhap ten phong: ");
            Name = Console.ReadLine();
            Console.Write("Nhap tang: ");
            Floor = Int32.Parse(Console.ReadLine());
            Console.Write("Nhap gia: ");
            Price = Double.Parse(Console.ReadLine());
            Console.Write("Nhap so nguoi toi da: ");
            MaxCustomer = Int32.Parse(Console.ReadLine());
        }

        public void display()
        {
            Console.WriteLine("Thong tin phong: Ten: {0}, Tang: {1}, Gia: {2}, So nguoi toi da: {3}.", Name, Floor, Price, MaxCustomer);
        }
    }
}
