using System;
using System.Collections.Generic;

namespace Bai68Phan3
{
    class Product
    {
        private string MaHH { get; set; }
        private string TenHH { get; set; }
        private float SoLuong { get; set; }
        private float Gia1SP { get; set; }

        public Product() { }

        public Product(string MaHH, string TenHH, float SoLuong, float Gia1SP)
        {
            this.MaHH = MaHH;
            this.TenHH = TenHH;
            this.SoLuong = SoLuong;
            this.Gia1SP = Gia1SP;
        }

        public void Input()
        {
            Console.WriteLine("Nhap ma hang hoa: ");
            MaHH = Console.ReadLine();

            Console.WriteLine("Nhap ten hang hoa: ");
            TenHH = Console.ReadLine();

            Console.WriteLine("Nhap so luong hang: ");
            SoLuong = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhap gia 1 san pham: ");
            Gia1SP = float.Parse(Console.ReadLine());
            
        }

        public void Display()
        {
            Console.WriteLine("Ma hang: {0}, Ten hang: {1}, So luong hang: {2}, Gia san pham: {3}", MaHH, TenHH, SoLuong, Gia1SP);
        }

        

        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so hang hoa can nhap vao: ");
            int n = int.Parse(Console.ReadLine());
            List<Product> list = new List<Product>();

            for(int i = 0; i < n; i++)
            {
                Product product = new Product();
                product.Input();

                list.Add(product);
            }

            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("Mat hang thu {0}: ", i + 1);
                list[i].Display();
            }

            float check;
            for (int i = 1; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (list[j].Gia1SP > list[i].Gia1SP)
                    {
                        check = list[i].Gia1SP;
                        list[i].Gia1SP = list[j].Gia1SP;
                        list[j].Gia1SP = check;
                    }
                }
            }

            

        }
        
        
        
    }
}
