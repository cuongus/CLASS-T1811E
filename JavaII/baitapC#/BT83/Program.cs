using System;
using System.Collections.Generic;
using System.IO;

namespace BT83
{
    class Program
    {
        static List<AptechBook> aptechBooks = new List<AptechBook>();
        static string fileName = "Aptech Books";
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
                        option6();
                        break;
                    case 7:
                        option7();
                        break;
                    case 8:
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Nhap sai!");
                        break;
                }
            } while (choose != 8);
        }

        static void option1()
        {
            Console.Write("Nhap so sach muon them: ");
            int n = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                AptechBook atpBook = new AptechBook();
                atpBook.input();
                aptechBooks.Add(atpBook);
            }
        }

        static void option2()
        {
            Console.WriteLine("Thong tin sach: ");
            foreach (AptechBook atpBook in aptechBooks)
            {
                atpBook.display();
            }
        }

        static void option3()
        {
            aptechBooks.Sort();
            aptechBooks.Reverse();
            Console.WriteLine("Thong tin sach: ");
            foreach (AptechBook atpBook in aptechBooks)
            {
                atpBook.display();
            }
        }
        static void option4()
        {
            Console.Write("Nhap ten sach can tim: ");
            string search = Console.ReadLine();

            foreach (AptechBook atpBook in aptechBooks)
            {
                if (search.Equals(atpBook.BookName))
                {
                    atpBook.display();
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
            string search = Console.ReadLine();

            foreach (AptechBook atpBook in aptechBooks)
            {
                if (search.Equals(atpBook.BookAuthor))
                {
                    atpBook.display();
                }
                else
                {
                    Console.WriteLine("Khong co sach nay!");
                }
            }
        }
        static void option6()
        {
            for (int i = 0; i < aptechBooks.Count; i++)
            {
                using (Stream stream = File.Open(fileName, FileMode.Create))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                    bformatter.Serialize(stream, aptechBooks[i]);
                }
            }
        }
        static void option7()
        {
            string content = System.IO.File.ReadAllText(fileName);

            aptechBooks = Newtonsoft.Json.JsonConvert.DeserializeObject<List<AptechBook>>(content);
            for (int i = 0; i < aptechBooks.Count; i++)
            {
                aptechBooks[i].display();
            }
        }
        static void menu()
        {
            Console.WriteLine("1. Nhap thong tin n sach Aptech.");
            Console.WriteLine("2. Hien thi sach Aptech.");
            Console.WriteLine("3. Sap xep giam dan theo nam.");
            Console.WriteLine("4. Tim kiem sach theo ten sach.");
            Console.WriteLine("5. Tim kiem sach theo ten tac gia.");
            Console.WriteLine("6. Luu thong tin ra file.");
            Console.WriteLine("7. Doc noi dung tu file va hien thi.");
            Console.WriteLine("8. Thoat.");
            Console.Write("Choose: ");
        }
    }
}
