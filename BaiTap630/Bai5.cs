using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap630
{
    class Bai5
    {
        static void Main(string[] args)
        {
            Console.Write("nhap so phan tu trong mang: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("n = " + n);

            int biendem = 0;
            for (int i = 1; i < biendem; i++)
            {
                if(n % i == 0)
                {
                    biendem++;
                }
            }
            if(biendem == 2)
            {
                Console.WriteLine(n + " la so nguyen to");
            }
            else
            {
                Console.WriteLine(n + " khong la so nguyen to");
            }
            Console.ReadKey();
        }
    }
}
