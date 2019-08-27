using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap630
{
    class Bai2
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so max: ");
            int max = int.Parse(Console.ReadLine());
            Console.WriteLine("Max = " + max);

            for(int i = 0; fibonacci(i) < max; i++)
            {
                Console.WriteLine(fibonacci(i) + "");
            }

            Console.ReadKey();
        }

        static int fibonacci(int k)
        {
            if (k < 0)
            {
                return -1;
            }else if(k == 0 || k == 1)
            {
                return k;
            }
            else
            {
                return fibonacci(k - 1) + fibonacci(k - 2);
            }
        }
    }
}
