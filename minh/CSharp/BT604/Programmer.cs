using System;

namespace BT604
{
    class Programmer : Employee, IPerson
    {
        private string _skills;
        private DateTime _DOB;
        private int _age;
        public static DateTime Now { get; }

        public Programmer(int id, string name) : base(id, name)
        {
            _skills = string.Empty;
            _DOB = Now;
        }

        public Programmer(int id, string name, string skills, DateTime dob) : base(id, name)
        {
            _skills = skills;
            _DOB = dob;
        }

        public string Skills
        {
            get
            {
                return this._skills;
            }
            set
            {
                if (value.Length < 0)
                {
                    throw new Exception();
                }
                this.Skills = _skills;
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return this._DOB;
            }
            set
            {
                this.DateOfBirth = _DOB;
            }
        }

        public int Age
        {
            get
            {
                return Now.CompareTo(DateOfBirth);
            }
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Id: {0} | Name: {1} | Skills: {2} | DOB: {3} | Age {4}", Id, Name, Skills, DateOfBirth, Age);
        }
    }
}
