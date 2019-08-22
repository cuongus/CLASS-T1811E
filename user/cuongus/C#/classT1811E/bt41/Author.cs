using System;
using System.Collections.Generic;
using System.Text;

namespace bt41
{
    class Author
    {
        public string Fullname { get; private set; }
        public string Age { get; private set; }     
        public string Pseudonym { get; private set; }
        public string Bdate { get; private set; }
        public string Place { get; private set; }

        public Author()
        { }
        public Author(string fullname, string age, string pseudonym, string bdate, string place)
        {
            Fullname = fullname;
            Age = age;
            Pseudonym = pseudonym;
            Bdate = bdate;
            Place = place;
        }

        public virtual void Input(List<Author> authors)
        {
            Console.WriteLine("Nhap ten TG: ");
            Fullname = Console.ReadLine();
            Console.WriteLine("Nhap tuoi Tg: ");
            Age = Console.ReadLine();
            Console.WriteLine("Nhap but danh: ");
            while (true)
            {
                Pseudonym = Console.ReadLine();
                if (CheckNickname(authors, Pseudonym))
                {
                    Console.WriteLine("But danh '{0}' da ton tai." +
                        "Nhap lai but danh: ", Pseudonym);

                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("Nhap ngay sinh: ");
            Bdate = Console.ReadLine();
            Console.WriteLine("Nhap que quan: ");
            Place = Console.ReadLine();

        }

        private bool CheckNickname(List<Author> authors, string pseudonym)
        {
            for (int i =0; i < authors.Count; i++)
            {
                if (authors[i].Pseudonym.Equals(pseudonym))
                {
                    return true;
                }
            }
            return false;
        }

        public virtual void Display()
        {
            Console.WriteLine("Ten TG: {0}, Tuoi: {1}, But danh: {2}, Ngay sinh: {3}, Que quan: {4}." , Fullname, Age, Pseudonym, Bdate, Place);
        }

    }
}
