using System;

namespace BT68
{
    class StudentMark
    {
        public string Rollnumber { get; set; }
        public string Fullname { get; set; }
        public string Classno { get; set; }
        public string Subject { get; set; }
        public double Mark { get; set; }

        public StudentMark() { }
        public StudentMark(string rollnumber, string fullname, string classno, string subject, double mark)
        {
            Rollnumber = rollnumber;
            Fullname = fullname;
            Classno = classno;
            Subject = subject;
            Mark = mark;
        }

        public void input()
        {
            Console.Write("Nhap so bao danh: ");
            Rollnumber = Console.ReadLine();
            Console.Write("Nhap ten: ");
            Fullname = Console.ReadLine();
            Console.Write("Nhap lop: ");
            Classno = Console.ReadLine();
            Console.Write("Nhap mon: ");
            Subject = Console.ReadLine();
            Console.Write("Nhap diem: ");
            Mark = double.Parse(Console.ReadLine());
        }

        public void display()
        {
            Console.WriteLine("So bao danh: " + Rollnumber + ", Ten: " + Fullname + ", Lop: " + Classno + ", Mon: " + Subject + ", Diem: " + Mark);
        }

        private void Main(string[] args)
        {
            StudentMark stdMark1 = new StudentMark();
            StudentMark stdMark2 = new StudentMark();

            stdMark1.input();
            stdMark2.input();

            stdMark1.display();
            stdMark2.display();

            Console.WriteLine("Sinh vien co diem cao nhat: ");
            if (stdMark1.Mark > stdMark2.Mark)
            {
                stdMark1.display();
            }
            else
            {
                stdMark2.display();
            }
        }
    }
}
