using System;
using System.Collections.Generic;

namespace bt445
{
    class Test
    {
        static void Main(string[] args)
        {
            int m = 0;
            List<Book> listBook = new List<Book>();

            /*
            Book[m] listBook = new Book[m]; */
            int n;
            do
            {
                shownMenu();
                Console.WriteLine("Nhap lua chon cua ban: ");
                n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Nhap so luong cuon sach can them: ");
                        m = int.Parse(Console.ReadLine());
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
                        listBook.Sort();
                        foreach (Book book in listBook)
                        {
                            book.Display();
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
            } while (n != 6  );
        }

        static void shownMenu()
        {
            Console.WriteLine("1. Nhap thong tin cuon sach.");
            Console.WriteLine("2. Hien thi thong tin cuon sach.");
            Console.WriteLine("3. Sap xep thong tin giam dan theo nam xuat ban va hien thi.");
            Console.WriteLine("4. Tim kiem cuon sach theo ten.");
            Console.WriteLine("5. Tim kiem cuon sach theo tac gia.");
            Console.WriteLine("6. Thoat.");
        }
    }
}
