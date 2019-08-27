using System;

namespace BaiTap630
{
    class Bai1
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("n = " + n);

            for(int i = n; i > 0; i--)
            {
                for(int j = i; j > 0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
