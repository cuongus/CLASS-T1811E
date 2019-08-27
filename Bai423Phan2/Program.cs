using System;

namespace Bai423Phan2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Giai pt bac 2 ax^2 + bx + c = 0");
            Console.WriteLine();
            double d, x1, x2;
            Console.WriteLine("Nhap a = ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b = ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap c = ");
            int c = int.Parse(Console.ReadLine());

            d = b * b - 4 * a * c;

            if(a == 0)
            {
                Console.WriteLine("Pt co nghiem x = " + (-b / c));
            }
            else
            {
                if (d < 0)
                {
                    Console.WriteLine("Pt vo nghiem");
                }
                else if (d == 0)
                {
                    Console.WriteLine("PT co 1 nghiem duy nhat x = " + (-b / (2 * a)));
                }
                else if (d > 0) ;
                {
                    Console.WriteLine("Pt co 2 nghiem phan biet x1 va x2 ");
                    Console.WriteLine("x1 = " + ((-b + Math.Sqrt(d)) / (2 * a)));
                    Console.WriteLine("x2 = " + ((-b - Math.Sqrt(d)) / (2 * a)));

                }
            }
            Console.ReadKey();
        }
    }
}
