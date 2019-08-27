using System;

namespace BaiTap68
{
    class StudentMark
    {
        public string rollNo { get; set; }
        public string fullName { get; set; }
        public string className { get; set; }
        public string subject { get; set; }
        public float mark { get; set; }

        public StudentMark() { }

        public StudentMark(string rollNo, string fullName, string className, string subject, float mark)
        {
            this.rollNo = rollNo;
            this.fullName = fullName;
            this.className = className;
            this.subject = subject;
            this.mark = mark;
        }

        public void Input()
        {
            Console.WriteLine("nhap rollNo: ");
            rollNo = Console.ReadLine();

            Console.WriteLine("nhap fullName: ");
            fullName = Console.ReadLine();

            Console.WriteLine("nhap className: ");
            className = Console.ReadLine();

            Console.WriteLine("nhap subject: ");
            subject = Console.ReadLine();

            Console.WriteLine("nhap rollNo: ");
            mark = float.Parse(Console.ReadLine());
        }

        public void Show()
        {
            Console.WriteLine("thong tin sinh vien ");
            Console.WriteLine("rollNo = {0},fullname = {1}, className = {2}, subject = {3}, mark = {4} ", rollNo, fullName, className, subject, mark);
        }
        static void Main(string[] args)
        {
            StudentMark stdMark1 = new StudentMark();
            StudentMark stdMark2 = new StudentMark();

            stdMark1.Input();
            stdMark2.Input();

            stdMark1.Show();
            stdMark2.Show();

            if(stdMark1.mark > stdMark2.mark)
            {
                stdMark1.Show();
            }else if(stdMark1.mark == stdMark2.mark)
            {
                Console.WriteLine("2 sv bang diem nhau");
            }
            else
            {
                stdMark2.Show();
            }
        }
    }
}
