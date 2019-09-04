using System;

namespace BT603
{
    class Parent
    {
        public string Name { get; set; }
        string Address { get; set; }
        string PhoneNumber { get; set; }
        public string ParentCode { get; set; }

        public Parent() { }
        public Parent(string name, string address, string phoneNumber, string parentCode)
        {
            this.Name = name;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.ParentCode = parentCode;
        }

        public void input()
        {
            Console.Write("Nhap ten:");
            Name = Console.ReadLine();
            Console.Write("Nhap dia chi:");
            Address = Console.ReadLine();
            Console.Write("Nhap so dien thoai:");
            PhoneNumber = Console.ReadLine();
            Console.Write("Nhap ma phu huynh:");
            ParentCode = Console.ReadLine();
        }

        public void display()
        {
            Console.WriteLine("Thong tin phu huynh: Ten: {0}, Dia chi: {1}, So dien thoai: {2}, Ma phu huynh: {3}.", Name, Address, PhoneNumber, ParentCode);
        }
    }
}
