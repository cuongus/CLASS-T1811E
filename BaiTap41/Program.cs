using System;
using System.Collections.Generic;
namespace BaiTap41
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Author> authors = new List<Author>();
            List<Book> books = new List<Book>();
            int choose;

            do
            {
                ShowMenu();
                choose = Int32.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        InputBook(books,authors);
                        break;
                    case 2:
                        ShowBook(books);
                        break;
                    case 3:
                        InputAuthor(authors);
                        break;
                    case 4:
                        Searching(books);
                        break;
                    case 5:
                        Console.WriteLine("Thoat chuong trinh !!!");
                        break;
                    default:
                        Console.WriteLine("Nhap sai!");
                        break;
                }
            } while (choose != 5);
            
        }

        static void Searching(List<Book> books)
        {
            Console.WriteLine("Nhap but danh can tim");
            string nickname = Console.ReadLine();

            for (int i=0;i<books.Count;i++)
            {
                if (books[i].NickName.Equals(nickname))
                {
                    books[i].Display();
                }
            }
        }

        static void InputBook(List<Book> books, List<Author> authors)
        {
            Console.WriteLine("Nhap so sach can them: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Book book = new Book();
                book.Input();

                books.Add(book);

                if (CheckExistNickName(authors, book.NickName))
                {
                    Author author = new Author(book.NickName);
                    author.Input();

                    authors.Add(author);
                }
            }
        }

        static void ShowBook(List<Book> books)
        {
            for(int i = 0; i < books.Count; i++)
            {
                books[i].Display();
            }
        }
        static void InputAuthor(List<Author> authors)
        {
            Console.WriteLine("Nhap so tac gia can them: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Author author = new Author();
                author.Input();

                authors.Add(author);
            }
        }

        static bool CheckExistNickName(List<Author> authors, string nickname)
        {
            for (int i = 0; i < authors.Count; i++)
            {
                if (authors[i].nickName.Equals(nickname))
                {
                    return true;
                }
            }
            return false;
        }
        static void ShowMenu()
        {
            Console.WriteLine("1. Nhap thong tin sach");
            Console.WriteLine("2. Hien thi tat ca cac sach");
            Console.WriteLine("3. Nhap thong tin tac gia");
            Console.WriteLine("4. Tim kiem tat ca sach duoc viet boi tac gia");
            Console.WriteLine("5. Thoat!!!");
            Console.WriteLine("Choose : ");
        }
    }
}
