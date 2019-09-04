using System;

namespace BT445
{
    class Book : IComparable<Book>
    {
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        private string Producer { get; set; }
        private int YearPublishing { get; set; }
        private float Price { get; set; }
        public int CompareTo(Book other)
        {
            return this.YearPublishing.CompareTo(other.YearPublishing);
        }

        public Book() { }
        public Book(string bookName, string bookAuthor, string producer, int yearPublishing, float price)
        {
            BookName = bookName;
            BookAuthor = bookAuthor;
            Producer = producer;
            YearPublishing = yearPublishing;
            Price = price;
        }

        public virtual void input()
        {
            Console.Write("Nhap ten sach: ");
            BookName = Console.ReadLine();
            Console.Write("Nhap ten tac gia: ");
            BookAuthor = Console.ReadLine();
            Console.Write("Nhap nha san xuat: ");
            Producer = Console.ReadLine();
            Console.Write("Nhap nam xuat ban: ");
            YearPublishing = int.Parse(Console.ReadLine());
            Console.Write("Nhap gia: ");
            Price = float.Parse(Console.ReadLine());
        }

        public virtual void display()
        {
            Console.Write("Ten sach:" + BookName + ", Ten tac gia:" + BookAuthor + ", Nha san xuat:" + Producer + ", Nam xuat ban:" + YearPublishing + ", Gia:" + Price);
        }
    }
}
