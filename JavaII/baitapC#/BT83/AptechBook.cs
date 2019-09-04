using System;

namespace BT83
{
    [Serializable]
    class AptechBook : Book
    {
        string Language { get; set; }
        int Semester { get; set; }

        public AptechBook() { }
        public AptechBook(string bookName, string bookAuthor, string producer, int yearPublishing, float price, string language, int semester) : base(bookName, bookAuthor, producer, yearPublishing, price)
        {
            this.Language = language;
            this.Semester = semester;
        }

        public override void input()
        {
            base.input();
            Console.Write("Nhap ngon ngu: ");
            Language = Console.ReadLine();
            Console.Write("Nhap ky hoc: ");
            Semester = Int32.Parse(Console.ReadLine());
        }

        public override void display()
        {
            base.display();
            Console.WriteLine(", Ngon ngu: {0}, Ky hoc: {1}.", Language, Semester);
        }
    }
}
