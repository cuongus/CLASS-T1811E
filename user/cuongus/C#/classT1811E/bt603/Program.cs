using System;
using System.Collections.Generic;

namespace bt603
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Students> listStudents = new List<Students>();
            List<Parents> listParents = new List<Parents>();
            int choose;
            do
            {
                shownMenu();
                Console.WriteLine("Nhap lua chon cua ban: ");
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("Nhap so luong Phu huynh: ");
                        int m = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap thong tin Phu huynh: ");
                        for (int i = 0; i < m; i++)
                        {
                            Parents parents1 = new Parents();
                            parents1.Input();
                            listParents.Add(parents1);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Nhap so luong Sinh vien: ");
                        int n = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap thong tin Sinh vien: ");
                        for (int i = 0; i < n; i++)
                        {
                            Students students1 = new Students();
                            students1.Input();
                            listStudents.Add(students1);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Nhap ten phu huynh: ");
                        string str1 = Console.ReadLine();
                        int count = 0;
                        int Pcode2;
                        for(int i = 0; i< listParents.Count; i++)
                        {
                            if(listParents[i].Fullname == str1)
                            {
                                Pcode2 = listParents[i].Pcode;
                                for (int j = 0; j < listStudents.Count; j++)
                                {
                                    if (listStudents[j].Pcode == Pcode2)
                                    {
                                        listStudents[j].Display();

                                    }
                                }
                            }
                            else { count++; }
                        }
                        
                        if (count != 0)
                        {
                            Console.WriteLine("Khong co ten Phu huynh: ");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Nhap ma SV: ");
                        int str2 = int.Parse(Console.ReadLine());
                        int count2 = 0;
                        int Pcode3;
                        for (int i = 0; i < listStudents.Count; i++)
                        {
                            if (listStudents[i].Scode == str2)
                            {
                                Pcode3 = listParents[i].Pcode;
                                for (int j = 0; j < listParents.Count; j++)
                                {
                                    if (listParents[j].Pcode == Pcode3)
                                    {
                                        listParents[j].Display();
                                        
                                    }
                                }
                            }
                            else { count2++; }
                        }
                        if (count2 != 0)
                        {
                            Console.WriteLine("Khong co maSV: ");
                        }
                        break;
                    case 5:
                        Console.WriteLine("delegate In thong tin Sv theo dia chi.");
                        break;
                    case 6:
                        Console.WriteLine("GoodBye !!!!!");
                        break;
                    default:
                        Console.WriteLine("Ban da nhap sai tham so.");
                        break;
                }
            } while (choose != 6);
        }

        static void shownMenu()
        {
            Console.WriteLine("1. Nhap thong phu huynh.");
            Console.WriteLine("2. Nhap thong tin sinh vien.");
            Console.WriteLine("3. In thong tin sinh vien theo phu huynh.");
            Console.WriteLine("4. In thong tin phu huynh theo sinh vien.");
            Console.WriteLine("5. In thong tin sinh vien theo dia chi nhap vao.");
            Console.WriteLine("6. Thoat.");
        }
    }
}
