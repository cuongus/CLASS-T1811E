using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap41
{


    class Author
    {
        public string fullName { get; private set; }
        public int age { get; private set; }
        public string nickName { get; private set; }
        public string birthDay { get; private set; }
        public string address { get; private set; }

        public Author(){

        }

        public Author(string nickName)
        {
            this.nickName = nickName;
        }

        public Author(string fullName,int age, string nickName, string birthDay, string address) {
            this.fullName = fullName;
            this.age = age;
            this.nickName = nickName;
            this.birthDay = birthDay;
            this.address = address;
        }

        public void Input(List<Author> authors)
        {
            Console.WriteLine("Nhap ten tac gia: ");
            fullName = Console.ReadLine();
            Console.WriteLine("Nhap tuoi tac gia: ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap but danh tac gia: ");
            nickName = Console.ReadLine();
            while (true)
            {
                if (CheckExistNickName(authors, nickName))
                {
                    nickName = Console.ReadLine();
                    Console.WriteLine("But danh {0} da ton tai, nhap lai: ", nickName);
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("Nhap ngay sinh tac gia: ");
            birthDay = Console.ReadLine();
            Console.WriteLine("Nhap dia chi tac gia: ");
            address = Console.ReadLine();
        }

        public void Input()
        {
            Console.WriteLine("Nhap ten tac gia: ");
            fullName = Console.ReadLine();
            Console.WriteLine("Nhap tuoi tac gia: ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ngay sinh tac gia: ");
            birthDay = Console.ReadLine();
            Console.WriteLine("Nhap dia chi tac gia: ");
            address = Console.ReadLine();
        }

        private bool CheckExistNickName(List<Author> authors,string nickname)
        {
            for (int i = 0; i < authors.Count; i++)
            {
                if (authors[i].nickName.Equals(nickname))
                {
                    return true;
                }
            }
            return false;
        }

        public void Display()
        {
            Console.WriteLine("Thong tin tac gia(Ho ten: {0}, Tuoi: {1}, But danh: {2}, Ngay sinh: {3}, Dia chi: {4})",fullName,age,nickName,birthDay,address);
        }
        

    }
}
