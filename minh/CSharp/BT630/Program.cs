using System;
using System.Collections.Generic;

namespace BT630
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int choose;

            do
            {
                Console.WriteLine("Nhap ten bai:");
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("Nhap n:");
                        n = int.Parse(Console.ReadLine());
                        bai1(n);
                        break;
                    case 2:
                        Console.WriteLine("Nhap n:");
                        n = int.Parse(Console.ReadLine());

                        for (int i = 0; i < n; i++)
                        {
                            if (bai2(i) < n)
                            {
                                Console.Write(bai2(i) + " ");
                            }
                        }
                        Console.WriteLine("");
                        break;
                    case 3:
                        break;
                    case 4:
                        Console.WriteLine("Nhap n:");
                        n = int.Parse(Console.ReadLine());
                        bai4(n);
                        Console.WriteLine("");
                        break;
                    case 5:
                        Console.WriteLine("Nhap n:");
                        n = int.Parse(Console.ReadLine());
                        bai5(n);
                        Console.WriteLine("");
                        break;
                    default:
                        break;
                }
            } while (choose != 5);
        }

        static void bai1(int n)
        {
            for (int i = n; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }

        static int bai2(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return bai2(n - 1) + bai2(n - 2);
            }
        }

        static void bai3()
        {

        }

        static void bai4(int n)
        {
            int position = 0;
            int[] list = new int[n];
            List<int> chan = new List<int>();
            List<int> le = new List<int>();
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine("Nhap so thu " + (i + 1) + ":");
                list[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] % 2 == 0)
                {
                    chan.Add(list[i]);
                }
                else
                {
                    le.Add(list[i]);
                }
            }

            le.Sort();
            chan.Sort();

            Console.WriteLine("Ket qua: ");
            foreach (int chanL in chan)
            {
                Console.Write(chanL + ",");
            }
            foreach (int leL in le)
            {
                Console.Write(leL + ",");
            }
        }

        static void bai5(int n)
        {
            int count = 0;
            for (int i = 2; i <= n; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }

                if (count == 2)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
