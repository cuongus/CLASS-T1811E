
using System;
using System.Collections.Generic;
using System.Text;

namespace Bai83
{
    class AptechBook : Book
    {
        internal string yearPublishing;

        internal int BookName;

        internal string BookAuthor;


        private String Language { get; set; }


        private int Semester { get; set; }

        public AptechBook()
        {
            
        }

        public AptechBook(string bookName, string bookAuthor, string producer, int yearPublishing, float price, string language, int semester) : base(bookName,bookAuthor,producer,yearPublishing,price)
        {
            this.Language = language;
            this.Semester = semester;
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhap ngon ngu sach: ");
            Language = Console.ReadLine();
            Console.WriteLine("Nhap hoc ki: ");
            Semester = int.Parse(Console.ReadLine());
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("\nNgon ngu sach: {0}, Hoc ki: {1}",Language,Semester);
        }
    }
}
