using System;

namespace BT41
{
    class Book
    {
        public string BookName { get; set; }
        public string Pseudonym { get; set; }
        public string DatePublishing { get; set; }
        public Book() { }
        public Book(string bookName, string pseudonym, string datePublishing)
        {
            this.BookName = bookName;
            this.Pseudonym = pseudonym;
            this.DatePublishing = datePublishing;
        }

        public void input()
        {
            Console.Write("Nhap ten sach: ");
            BookName = Console.ReadLine();
            Console.Write("Nhap but danh: ");
            Pseudonym = Console.ReadLine();
            Console.Write("Nhap ngay xuat ban: ");
            DatePublishing = Console.ReadLine();
        }

        public void display()
        {
            Console.WriteLine("Thong tin sach: Ten: {0}, But danh: {1}, Ngay xuat ban: {2}.", BookName, Pseudonym, DatePublishing);
        }
    }
}
