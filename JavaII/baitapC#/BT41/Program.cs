using System;
using System.Collections.Generic;

namespace BT41
{
    class Program
    {
        static List<Book> bookList = new List<Book>();
        static List<Author> authorList = new List<Author>();
        static void Main(string[] args)
        {
            int choose;
            do
            {
                menu();
                choose = Int32.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        option1();
                        break;
                    case 2:
                        option2();
                        break;
                    case 3:
                        option3();
                        break;
                    case 4:
                        option4();
                        break;
                    case 5:
                        option5();
                        break;
                    case 6:
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Nhap sai!");
                        break;
                }
            } while (choose != 6);
        }

        static void option1()
        {
            Book book = new Book();
            book.input();
            if (!checkPseudonym(book.Pseudonym))
            {
                Author author = new Author(book.Pseudonym);
                author.input();
                authorList.Add(author);
            }
            bookList.Add(book);
        }

        static void option2()
        {
            foreach (Book book in bookList)
            {
                book.display();
            }
        }

        static void option3()
        {
            Author author = new Author();
            author.input(authorList);
            authorList.Add(author);
        }

        static void option4()
        {
            Console.Write("Nhap ten tac gia: ");
            string search = Console.ReadLine();
            string cache = "";

            foreach (Author author in authorList)
            {
                if (search.Equals(author.AuthorName))
                {
                    cache = author.Pseudonym;
                }
            }

            foreach (Book book in bookList)
            {
                if (cache.Equals(book.Pseudonym))
                {
                    book.display();
                }
                else
                {
                    Console.WriteLine("Tac gia khong dung!");
                }
            }
        }

        static void option5()
        {
            Console.Write("Nhap ten sach muon tim: ");
            string search = Console.ReadLine();

            foreach (Book book in bookList)
            {
                if (search.Equals(book.BookName))
                {
                    book.display();
                }
                else
                {
                    Console.WriteLine("Ten sach khong dung!");
                }
            }
        }

        static void menu()
        {
            Console.WriteLine("1. Nhap thong tin sach.");
            Console.WriteLine("2. Hien thi tat ca sach.");
            Console.WriteLine("3. Nhap thong tin tac gia.");
            Console.WriteLine("4. Tim kiem sach theo tac gia.");
            Console.WriteLine("5. Tim kiem sach theo ten.");
            Console.WriteLine("6. Thoat.");
            Console.Write("Choose: ");
        }

        private static bool checkPseudonym(string pseudonym)
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
    }
}
