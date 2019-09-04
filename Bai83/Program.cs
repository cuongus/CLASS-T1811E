using System;
using System.Collections.Generic;
namespace Bai83
{
    class Test
    {
        static void Main(string[] args)
        {
            List<AptechBook> aptechBooks = new List<AptechBook>();
            int choose;
            do
            {
                ShowMenu();
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Input(aptechBooks);
                        break;
                    case 2:
                        Display(aptechBooks);
                        break;
                    case 3:
                        Sort(aptechBooks);
                        break;
                    case 4:
                        SearchingBookName(aptechBooks);
                        break;
                    case 5:
                        SearchingBookAuthor(aptechBooks);
                        break;
                    case 6:
                        Console.WriteLine("Thoat!!!");
                        break;
                    default:
                        Console.WriteLine("Nhap sai!!! Nhap lai");
                        break;
                }

            } while (choose != 6);
        }

        static void Input(List<AptechBook> aptechBooks)
        {
            Console.WriteLine("Nhap so sach can nhap: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                AptechBook book = new AptechBook();
                book.Input();

                aptechBooks.Add(book);
            }
        }
        static void Display(List<AptechBook> aptechBooks)
                {
                    for(int i = 0; i < aptechBooks.Count; i++)
                    {
                        aptechBooks[i].Display();
                    }
                }
        static void Sort(List<AptechBook> aptechBooks)
        {
            aptechBooks.Sort(
                (AptechBook o1,AptechBook o2) =>
                {
                    return string.Compare(o1.yearPublishing, o2.yearPublishing, StringComparison.OrdinalIgnoreCase);
                }
                );
            Display(aptechBooks);
        }

        static void SearchingBookName(List<AptechBook> aptechBooks)
        {
            Console.WriteLine("Nhap ten sach can tim: ");
            string searching = Console.ReadLine();

            for(int i = 0; i < aptechBooks.Count; i++)
            {
                if (aptechBooks[i].BookName.Equals(searching))
                {
                    aptechBooks[i].Display();
                }
            }
        }

        static void SearchingBookAuthor(List<AptechBook> aptechBooks)
        {
            Console.WriteLine("Nhap ten sach can tim: ");
            string searching = Console.ReadLine();

            for (int i = 0; i < aptechBooks.Count; i++)
            {
                if (aptechBooks[i].BookAuthor.Equals(searching))
                {
                    aptechBooks[i].Display();
                }
            }
        }

        static void ShowMenu()
        {
            Console.WriteLine("1. Nhập thông tin n cuốn sách của Aptech");
            Console.WriteLine("2. Hiển thị thông tin vừa nhập");
            Console.WriteLine("3. Sắp xếp thông tin giảm dần theo năm xuất bản và hiển thị");
            Console.WriteLine("4. Tìm kiếm theo tên sách");
            Console.WriteLine("5. Tìm kiếm theo tên tác giả");
            Console.WriteLine("6. Thoát.");
            Console.WriteLine("Choose: ");
        }
    }
}
