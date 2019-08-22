using System;
using System.Collections.Generic;

namespace bt41
{
    class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CHUONG TRINH QUAN LY SACH!");
            Console.WriteLine("---------------------------");
            List<Author> listAuthor = new List<Author>();
            List<Book> listBook = new List<Book>();
            int choose;
            do
            {
                shownMenu();
                Console.WriteLine("Nhap lua chon cua ban: ");
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("Nhap so luong cuon sach can them: ");
                        int m = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap thong tin cuon sach: ");
                        for (int i = 0; i < m; i++)
                        {
                            Book book = new Book();
                            book.Input();
                            listBook.Add(book);
                        }
                        break;
                    case 2:
                        for (int i = 0; i < listBook.Count; i++)
                        {
                            listBook[i].Display();
                        }
                        break;
                    case 3:
                        Console.WriteLine("Nhap so luong tac gia: ");
                        int j = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap thong tin tac gia: ");
                        for(int i = 0; i < j; i++)
                        {
                            Author author = new Author();
                            author.Input(listAuthor);
                            listAuthor.Add(author);
                        }
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        Console.WriteLine("GoodBye !!!!!");
                        break;
                    default:
                        Console.WriteLine("Ban da nhap sai tham so.");
                        break;
                }
            }
            while (choose != 6);
        
        }

        static void shownMenu()
        {
            Console.WriteLine("1. Nhap thong tin cuon sach.");
            Console.WriteLine("2. Hien thi thong tin cuon sach.");
            Console.WriteLine("3. Nhap thong tin tac gia.");
            Console.WriteLine("4. Tim kiem cuon sach theo tac gia.");
            Console.WriteLine("5. Tim kiem cuon sach.");
            Console.WriteLine("6. Thoat.");
        }
    }
}
