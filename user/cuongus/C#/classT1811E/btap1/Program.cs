using System;

namespace btap1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so tu nhien n: ");
            int n;
            n = int.Parse(Console.ReadLine());

            for (int i = n; i > 0; --i)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("De quy khong nho: " + f(n));
            Console.WriteLine("De quy co nho: " + dequyconho(n));

            Console.WriteLine("Nhap so max de print day fibonaci nho hon max: ");
            int max;
            max = int.Parse(Console.ReadLine());
            int m = 1;
            Console.WriteLine("Day fibonaci nho hon: " + max);
            do
            {
                Console.Write("  " + f(m));
                m++;
            } while (f(m) < max);
            Console.WriteLine(" ");

            Console.WriteLine("Nhap kich thuoc cua mang:  ");
            int x = int.Parse(Console.ReadLine());
            int[] array = new int[x];
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Nhap phan tu thu " + i);
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Phan tu cua mang: ");
            for (int i = 0; i < x; i++)
            { 
                Console.Write(" " + array[i]);
            }
            int temp = 0;
            
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x-1; j++)
                {
                    if((array[i] % 2 == 0) && (array[j]) % 2 != 0)
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            
            for (int i=0; i<x; i++)
            {
                for (int j= 0; j< x-1; j++)
                {
                    if((array[i] < array[j]) && array[i] % 2 == 0 & array[j] % 2 == 0)
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x - 1; j++)
                {
                    if ((array[i] < array[j]) && array[i] % 2 != 0 & array[j] % 2 != 0)
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            Console.WriteLine("Phan tu cua mang: ");
            for (int i = 0; i < x; i++)
            {
                Console.Write(" " + array[i]);
            }


        }
        static int f(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return (f(n - 1) + f(n - 2));
            }
        }
        
        static int dequyconho(int n)
        {
            int[] list = new int[n];
            for (int i = 0; i < n; i++) {
                list[i] = 0;
            }

            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                if (list[n-1] != 0)
                {
                    return list[n];
                }
                else
                {
                    list[n-1] = (f(n - 1) + f(n - 2));
                    return list[n-1];
                }
            }
        }
    }
}
