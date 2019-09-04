using System;
using System.Collections.Generic;

namespace BT445
{
    class Program
    {
        static List<AptechBook> aptechBook = new List<AptechBook>();
        static void Main(string[] args)
        {
            int choose;
            do
            {
                menu();
                choose = int.Parse(Console.ReadLine());
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
                        Console.WriteLine("Chon sai!");
                        break;
                }
            } while (choose != 6);
        }

        static void option1()
        {
            Console.Write("Nhap so sach muon them: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                AptechBook atB = new AptechBook();
                atB.input();

                aptechBook.Add(atB);
            }
        }

        static void option2()
        {
            foreach (AptechBook atB in aptechBook)
            {
                atB.display();
            }
        }

        static void option3()
        {
            aptechBook.Sort();
            aptechBook.Reverse();
            foreach (AptechBook atB in aptechBook)
            {
                atB.display();
            }
        }

        static void option4()
        {
            Console.Write("Nhap ten sach can tim: ");
            string find = Console.ReadLine();

            foreach (AptechBook atB in aptechBook)
            {
                if (find.Equals(atB.BookName))
                {
                    atB.display();
                }
                else
                {
                    Console.WriteLine("Khong co sach nay!");
                }
            }
        }

        static void option5()
        {
            Console.Write("Nhap ten tac gia can tim: ");
            string find = Console.ReadLine();

            foreach (AptechBook atB in aptechBook)
            {
                if (find.Equals(atB.BookAuthor))
                {
                    atB.display();
                }
                else
                {
                    Console.WriteLine("Khong co tac gia nay!");
                }
            }
        }
        static void menu()
        {
            Console.WriteLine("1. Nhap n cuon sach Aptech.");
            Console.WriteLine("2. Hien thi.");
            Console.WriteLine("3. Sap xep giam dan theo nam xuat ban.");
            Console.WriteLine("4. Tim kiem theo ten sach.");
            Console.WriteLine("5. Tim kiem theo ten tac gia.");
            Console.WriteLine("6. Thoat.");
            Console.Write("Choose: ");
        }
    }
}
