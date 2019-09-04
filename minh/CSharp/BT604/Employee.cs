using System;

namespace BT604
{
    abstract class Employee
    {
        private int _id;
        private string _name;

        public Employee(int id)
        {
            this._id = id;
            this._name = "No name";
        }

        public Employee(int id, string name)
        {
            this._id = id;
            this._name = name;
        }

        public int Id { get { return this._id; } }
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("Nhap sai!");
                    return;
                }
                this.Name = _name;
            }
        }

        public abstract void ShowInfo();
    }
}
