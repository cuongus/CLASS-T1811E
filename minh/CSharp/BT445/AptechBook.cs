using System;

namespace BT445
{
    class AptechBook : Book
    {
        private string Language { get; set; }
        private int Semester { get; set; }

        public AptechBook() { }
        public AptechBook(string bookName, string bookAuthor, string producer, int yearPublishing, float price, string language, int semester) : base(bookName, bookAuthor, producer, yearPublishing, price)
        {
            Language = language;
            Semester = semester;
        }

        public override void input()
        {
            base.input();
            Console.Write("Nhap ngon ngu: ");
            Language = Console.ReadLine();
            Console.Write("Nhap ky hoc: ");
            Semester = int.Parse(Console.ReadLine());
        }

        public override void display()
        {
            base.display();
            Console.WriteLine(", Ngon ngu:" + Language + ", Ky hoc:" + Semester);
        }
    }
}
