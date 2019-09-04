using System;
using System.Collections.Generic;

namespace BT41
{
    class Author
    {
        public string AuthorName { get; private set; }
        public int AuthorAge { get; private set; }
        public string Pseudonym { get; private set; }
        public string Birthday { get; private set; }
        public string Address { get; private set; }

        public Author() { }

        public Author(string pseudonym)
        {
            this.Pseudonym = pseudonym;
        }
        public Author(string authorName, int authorAge, string pseudonym, string birthday, string address)
        {
            this.AuthorName = authorName;
            this.AuthorAge = authorAge;
            this.Pseudonym = pseudonym;
            this.Birthday = birthday;
            this.Address = address;
        }

        //input khong check
        public void input()
        {
            Console.Write("Nhap ten tac gia: ");
            AuthorName = Console.ReadLine();
            Console.Write("Nhap tuoi: ");
            AuthorAge = int.Parse(Console.ReadLine());
            Console.Write("Nhap ngay sinh: ");
            Birthday = Console.ReadLine();
            Console.Write("Nhap que quan: ");
            Address = Console.ReadLine();
        }

        //input co check
        public void input(List<Author> authorList)
        {
            Console.Write("Nhap ten tac gia: ");
            AuthorName = Console.ReadLine();
            Console.Write("Nhap tuoi: ");
            AuthorAge = int.Parse(Console.ReadLine());
            Console.Write("Nhap but danh: ");
            while (true)
            {
                Pseudonym = Console.ReadLine();
                if (checkPseudonym(authorList, Pseudonym))
                {
                    Console.WriteLine("But danh {0} da ton tai. Thu lai: ", Pseudonym);
                }
                else
                {
                    break;
                }
            }
            Console.Write("Nhap ngay sinh: ");
            Birthday = Console.ReadLine();
            Console.Write("Nhap que quan: ");
            Address = Console.ReadLine();
        }

        private bool checkPseudonym(List<Author> authorList, string pseudonym)
        {
            for (int i = 0; i < authorList.Count; i++)
            {
                if (authorList[i].Pseudonym.Equals(pseudonym))
                {
                    return true;
                }
            }
            return false;
        }

        public void display()
        {
            Console.WriteLine("Thong tin tac gia: Ten: {0}, Tuoi: {1}, But danh: {2}, Ngay sinh: {3}, Que quan: {4}.", AuthorName, AuthorAge, Pseudonym, Birthday, Address);
        }
    }
}
