using System;
using System.Collections.Generic;
using System.IO;

namespace BT565
{
    class Program
    {
        static List<Hotel> hotelList = new List<Hotel>();
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
            Console.Write("Nhap n: ");
            int n = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Hotel hotel = new Hotel();
                hotel.input();

                hotelList.Add(hotel);
            }
        }

        static void option2()
        {
            foreach (Hotel hotel in hotelList)
            {
                hotel.display();
            }
        }

        static void option3()
        {
            string json = "";
            foreach (Hotel hotel in hotelList)
            {
                json = Newtonsoft.Json.JsonConvert.SerializeObject(hotel);
                using (Stream stream = File.Open("data.json", FileMode.Create))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                    bformatter.Serialize(stream, json);
                }
            }
        }

        static void option4()
        {
            using (Stream stream = File.Open("student.dat", FileMode.Open))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                hotelList = (List<Hotel>)binaryFormatter.Deserialize(stream);
            }
        }

        static void option5()
        {
            string fileName = "", json = "";

            foreach (Hotel hotel in hotelList)
            {
                fileName = hotel.Name + ".java";
                json = Newtonsoft.Json.JsonConvert.SerializeObject(hotel);
                using (Stream stream = File.Open(fileName, FileMode.Create))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                    bformatter.Serialize(stream, json);
                }
            }

        }
        static void menu()
        {
            Console.WriteLine("1. Nhap thong tin n khach san.");
            Console.WriteLine("2. Hien thi thong tin khach san.");
            Console.WriteLine("3. Luu vao file data.json.");
            Console.WriteLine("4. Luu tu file json vao mang.");
            Console.WriteLine("5. Luu thong tin tung khach san vao tung file.");
            Console.WriteLine("6. Thoat.");
            Console.WriteLine("Choose: ");
        }
    }
}
