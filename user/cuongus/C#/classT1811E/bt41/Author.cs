using System;
using System.Collections.Generic;
using System.Text;

namespace bt41
{
    class Author
    {
        public string Fullname { get; private set; }
        public string Age { get; private set; }
        public string bd;
        string str;
        public string Pseudonym {
            get
            {
                return this.bd;
            }

            set
            {
                if(str == bd)
                {
                    Console.WriteLine("sssssssssss");
                    return;
                }
                this.bd = str;
            }
        }
     
        public string Bdate { get; private set; }
        public string Place { get; private set; }

        public Author()
        { }
        public Author(string fullname, string age, string pseudonym, string bdate, string place)
        {
            Fullname = fullname;
            Age = age;
            Pseudonym = pseudonym;
            Bdate = bdate;
            Place = place;
        }

        public virtual void Input()
        {
            Console.WriteLine("Nhap ten TG: ");
            Fullname = Console.ReadLine();
            Console.WriteLine("Nhap tuoi Tg: ");
            Age = Console.ReadLine();
            Console.WriteLine("Nhap but danh: ");
            Pseudonym = Console.ReadLine();
            Console.WriteLine("Nhap ngay sinh: ");
            Bdate = Console.ReadLine();
            Console.WriteLine("Nhap que quan: ");
            Place = Console.ReadLine();

        }

        public virtual void Display()
        {
            Console.WriteLine("Ten TG: {0}, Tuoi: {1}, But danh: {2}, Ngay sinh: {3}, Que quan: {4}." , Fullname, Age, Pseudonym, Bdate, Place);
        }

    }
}
