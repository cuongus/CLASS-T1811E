using System;

namespace BaiTap423
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Giai pt bac nhat ax + b = 0");
            Console.WriteLine();
            Console.WriteLine("Nhap a = ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b = ");
            int b = int.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("Pt vo so nghiem");
            }
            else
            {
                Console.WriteLine("Pt co nghiem x =" + (-b / a));
            }


            Console.ReadKey();
        }
    }
}
