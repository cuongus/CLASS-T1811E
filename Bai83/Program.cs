using System;

namespace Bai83
{
    class Book
    {
        private String bookName { get; set; }

        private String bookAuthor { get; set; }

        private String producer { get; set; }

        private int yearPublishing { get; set; }

        private float price { get; set; }

        private Book()
        {

        }

        private Book(string bookName, string bookAuthor, string producer,int yearPublishing,float price)
        {
            this.bookName = bookName;
            this.bookAuthor = bookAuthor;
            this.producer = producer;
            this.yearPublishing = yearPublishing;
            this.price = price;
        }

        private void Input()
        {
            Console.WriteLine("Nhap ten sach: ");
            bookName = Console.ReadLine();
            Console.WriteLine("Nhap ten tac gia: ");
            bookAuthor = Console.ReadLine();
            Console.WriteLine("Nhap nha xuat ban: ");
            producer = Console.ReadLine();
            Console.WriteLine("Nhap nam xuat ban: ");
            yearPublishing = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap gia sach: ");
            price = float.Parse(Console.ReadLine());
        }

        private void Display()
        {
            Console.WriteLine("Thong tin cua sach: (Ten sach: {0},ten tac gia: {1},nha xuat ban: {2}, nam xuat ban: {3}, gia sach: {4} ", bookName, bookAuthor, producer, yearPublishing, price);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
