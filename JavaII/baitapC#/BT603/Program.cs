using System;
using System.Collections.Generic;

namespace BT603
{
    class Program
    {
        public delegate Student OnAddressPrint(string address);
        static event OnAddressPrint EventAddressPrint;
        static List<Student> studentList = new List<Student>();
        static List<Parent> parentList = new List<Parent>();
        static void Main(string[] args)
        {
            int choose;
            do
            {
                menu();
                choose = Int32.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        option1();
                        break;
                    case 2:
                        option2();
                        break;
                    case 3:
                        option3();
                        break;
                    case 4:
                        option4();
                        break;
                    case 5:
                        option5();
                        break;
                    case 6:
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Nhap sai!");
                        break;
                }
            } while (choose != 6);
        }

        static void option1()
        {
            Console.Write("Nhap so phu huynh muon them: ");
            int n = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Parent parent = new Parent();
                parent.input();

                parentList.Add(parent);
            }
        }

        static void option2()
        {
            foreach (Parent parent in parentList)
            {
                Console.WriteLine("Ma phu huynh: " + parent.ParentCode);
            }
            Console.Write("Nhap ma phu huynh cua sinh vien: ");
            string parentCode = Console.ReadLine();

            Console.Write("Nhap so sinh vien muon them: ");
            int m = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                Student student = new Student(parentCode);
                student.input();

                studentList.Add(student);
            }
        }

        static void option3()
        {
            Console.Write("Nhap ten phu huynh muon tim: ");
            string search = Console.ReadLine();
            string parentCode = null;

            foreach (Parent parent in parentList)
            {
                if (search.Equals(parent.Name))
                {
                    parentCode = parent.ParentCode;
                }
            }

            foreach (Student student in studentList)
            {
                if (parentCode != null && parentCode.Equals(student.ParentCode))
                {
                    student.display();
                }
            }
        }

        static void option4()
        {
            Console.WriteLine("Nhap ma sinh vien muon tim:");
            string search = Console.ReadLine();
            string parentCode = null;

            foreach (Student student in studentList)
            {
                if (search.Equals(student.StudentCode))
                {
                    parentCode = student.ParentCode;
                }
            }

            foreach (Parent parent in parentList)
            {
                if (parentCode != null && parentCode.Equals(parent.ParentCode))
                {
                    parent.display();
                }
            }
        }

        static void option5()
        {
            Console.Write("Nhap dia chi: ");
            string address = Console.ReadLine();

            OnAddressPrint search = new OnAddressPrint(timSV);
            EventAddressPrint = new OnAddressPrint(search);

            Student student = EventAddressPrint(address);
            student.display();

            if (student == null)
            {
                Console.WriteLine("Khong co sinh vien.");
            }
        }

        static Student timSV(string address)
        {
            foreach (Student student in studentList)
            {
                if (address.Equals(student.Address))
                {
                    return student;
                }
            }
            return null;
        }
        static void menu()
        {
            Console.WriteLine("1. Nhap thong tin phu huynh.");
            Console.WriteLine("2. Nhap thong tin sinh vien.");
            Console.WriteLine("3. In ra thong tin sinh vien theo ten phu huynh.");
            Console.WriteLine("4. In ra thong tin phu huynh theo ma sinh vien.");
            Console.WriteLine("5. Tim sinh vien qua dia chi.");
            Console.WriteLine("6. Thoat.");
            Console.WriteLine("Choose: ");
        }
    }
}
