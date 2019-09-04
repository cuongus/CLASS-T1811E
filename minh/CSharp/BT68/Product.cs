using System;
using System.Collections.Generic;

namespace BT68
{
    class Product
    {
        private string MaHH { get; set; }
        private string TenHH { get; set; }
        private float SoLuong { get; set; }
        private float Gia1SP { get; set; }

        public Product() { }
        public Product(string maHH, string tenHH, float soLuong, float gia1SP)
        {
            MaHH = maHH;
            TenHH = tenHH;
            SoLuong = soLuong;
            Gia1SP = gia1SP;
        }

        public void input()
        {
            Console.Write("Nhap ma hang hoa: ");
            MaHH = Console.ReadLine();
            Console.Write("Nhap ten hang hoa: ");
            TenHH = Console.ReadLine();
            Console.Write("Nhap so luong hang hoa: ");
            SoLuong = float.Parse(Console.ReadLine());
            Console.Write("Nhap gia 1 san pham: ");
            Gia1SP = float.Parse(Console.ReadLine());
        }

        public void display()
        {
            Console.WriteLine("Ma hang hoa: " + MaHH + ", Ten hang hoa: " + TenHH + ", So luong: " + SoLuong + ", Gia san pham: " + Gia1SP);
        }

        private void Main(string[] args)
        {
            List<Product> productList = new List<Product>();

            Console.Write("Nhap so luong hang hoa muon them: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Product product = new Product();
                product.input();

                productList.Add(product);
            }

            Console.Write("San pham co gia ban cao nhat la: ");
            float x = productList[0].Gia1SP;
            for (int i = 0; i < n; i++)
            {
                if (x < productList[i].Gia1SP)
                {
                    x = productList[i].Gia1SP;
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (x == productList[i].Gia1SP)
                {
                    productList[i].display();
                }
            }

        }
    }
}
