using System;
using System.IO;
using System.Collections.Generic;

namespace bt565
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int m;
            int n;
            List<Hotel> listHotel = new List<Hotel>();
            List<Room> listRoom = new List<Room>();
            do
            {
                showMenu();
                Console.WriteLine("Nhap lua chon cua ban: ");
                n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Nhap so luong khach san: ");
                        m = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap thong tin khach san: ");
                        for (int i = 0; i < m; i++)
                        {
                            Hotel hotel = new Hotel();
                            hotel.Input();
                            listHotel.Add(hotel);
                        }
                        break;
                    case 2:
                        for (int i = 0; i < listHotel.Count; i++)
                        {
                            listHotel[i].Display();
                        }
                        break;
                    case 3:
                        Export(listHotel);
                        break;
                    case 4:
                        listRoom = Import();
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
            } while (n != 6);
        }

        static List<Room> Import() 
        {
            string content = System.IO.File.ReadAllText(@"data.json");
            //Console.WriteLine(content);
            
            List<Room> list = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Room>>(content);
            for(int i = 0; i< list.Count; i++)
            {
                list[i].Display();
            }
            return null;
        }
        static void Export(List<Hotel> list)
        {
            //List<Hotel> list = new List<Hotel>();
            for (int i = 0; i < list.Count;i++)
            {
                //System.IO.File.AppendAllText("hotel.txt", list[i].ToString() + " ");
                Hotel hotel = list[i];
                string filename = hotel.TenKS;
                using (Stream stream = File.Open(filename, FileMode.Create))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    bformatter.Serialize(stream, hotel);
                }
            }

        }
        static void showMenu()
        {
            Console.WriteLine("1. Nhap thong tin khach san.");
            Console.WriteLine("2. Hien thi thong tin khach san.");
            Console.WriteLine("3. Export du lieu ra file json va luu.");
            Console.WriteLine("4. Import file json va luu vao mang.");
            Console.WriteLine("5. Luu thong tin tung KH vao 1 file.");
            Console.WriteLine("6. Thoat.");
        }
    }
}
