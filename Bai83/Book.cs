using System;
using System.Collections.Generic;
using System.Text;

namespace Bai83
{
    class Book
    {
        private String BookName { get; set; }

        private String BookAuthor { get; set; }

        private String Producer { get; set; }

        private int YearPublishing { get; set; }

        private float Price { get; set; }

        public Book()
        {

        }

        public Book(string bookName, string bookAuthor, string producer, int yearPublishing, float price)
        {
            this.BookName = bookName;
            this.BookAuthor = bookAuthor;
            this.Producer = producer;
            this.YearPublishing = yearPublishing;
            this.Price = price;
        }

        public virtual void Input()
        {
            Console.WriteLine("Nhap ten sach: ");
            BookName = Console.ReadLine();
            Console.WriteLine("Nhap ten tac gia: ");
            BookAuthor = Console.ReadLine();
            Console.WriteLine("Nhap ten nha xuat ban: ");
            Producer = Console.ReadLine();
            Console.WriteLine("Nhap nam xuat ban: ");
            YearPublishing = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap gia sach: ");
            Price = float.Parse(Console.ReadLine());
        }

        public virtual void Display()
        {
            Console.WriteLine("Thong tin sach:\nTen sach: {0},Ten tac gia: {1}, Ten nha xuat ban: {2}, Nam xuat ban: {3}, Gia sach: {4}", BookName, BookAuthor, Producer, YearPublishing, Price);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
