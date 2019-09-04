using System;

namespace BT83
{
    [Serializable]
    class Book : IComparable<Book>
    {
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        string Producer { get; set; }
        int YearPublishing { get; set; }
        float Price { get; set; }
        public int CompareTo(Book other)
        {
            return this.YearPublishing.CompareTo(other.YearPublishing);
        }

        public Book() { }

        public Book(string bookName, string bookAuthor, string producer, int yearPublishing, float price)
        {
            this.BookName = bookName;
            this.BookAuthor = bookAuthor;
            this.Producer = producer;
            this.YearPublishing = yearPublishing;
            this.Price = price;
        }

        public virtual void input()
        {
            Console.Write("Nhap ten sach: ");
            BookName = Console.ReadLine();
            Console.Write("Nhap ten tac gia: ");
            BookAuthor = Console.ReadLine();
            Console.Write("Nhap nha xuat ban: ");
            Producer = Console.ReadLine();
            Console.Write("Nhap nam xuat ban: ");
            YearPublishing = Int32.Parse(Console.ReadLine());
            Console.Write("Nhap gia: ");
            Price = float.Parse(Console.ReadLine());
        }

        public virtual void display()
        {
            Console.Write("Thong tin sach: Ten: {0}, Tac gia: {1}, Nha xuat ban: {2}, Nam xuat ban: {3}, Gia: {4}.", BookName, BookAuthor, Producer, YearPublishing, Price);
        }
    }
}
