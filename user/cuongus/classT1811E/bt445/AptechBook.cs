using System;
using System.Collections.Generic;
using System.Text;

namespace bt445
{
    public class AptechBook : Book
    {
        public string Language { private get; set; }
        public int Semester { private get; set; }

        public AptechBook()
        {

        }
        public AptechBook(string bookName, string bookAuthor, int yearPublising, float price, string producer ,string language, int semester) : base(bookName, bookAuthor, producer, yearPublising, price)
        {
            Language = language;
            Semester = semester;
        }   

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhap ngon ngu: ");
            Language = Console.ReadLine();
            Console.WriteLine("Nhap hoc ky: ");
            Semester = int.Parse(Console.ReadLine());
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Ngon ngu {0}, Hoc ky {1}", Language, Semester);
        }
    }
}
