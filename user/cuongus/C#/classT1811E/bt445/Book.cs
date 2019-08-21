using System;
using System.Collections.Generic;
using System.Text;

namespace bt445
{
    public class Book : IComparable<Book>
    {
        public string BookName { private get; set; }
        public string BookAuthor { private get; set; }
        public string Producer { private get; set; }
        public int YearPublising { private get; set; }
        public float Price { private get; set; }

        public Book() {
        }
        public Book(string bookName, string bookAuthor, string producer, int yearPublising, float price)
        {
            BookName = bookName;
            BookAuthor = bookAuthor;
            Producer = producer;
            YearPublising = yearPublising;
            Price = price;
        }

        public virtual void Input()
        {
            Console.WriteLine("Nhap ten cuon sach: ");
            BookName = Console.ReadLine();
            Console.WriteLine("Nhap ten tac gia: ");
            BookAuthor = Console.ReadLine();
            Console.WriteLine("Nhap ten nha xuat ban: ");
            Producer = Console.ReadLine();
            Console.WriteLine("Nhap nam xuat ban: ");
            YearPublising = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap gia cuon sach: ");
            Price = float.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------");
        }

        public virtual void Display()
        {
            Console.WriteLine("Ten CS {0}, Tac gia {1}, NXB {2}, Nam XB {3}, Gia ban {4}." , BookName, BookAuthor, Producer, YearPublising, Price);
        }

        public int CompareTo(Book obj)
        {
        
            return this.YearPublising.CompareTo(obj.YearPublising);
           
        }

    }
}
