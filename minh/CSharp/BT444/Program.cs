using Room;
using System;

namespace BT444
{
    class Program
    {
        static void Main(string[] args)
        {
            Table table1 = new Table();
            table1.input();
            Table table2 = new Table("BBB", "Do", "Hong Ha", 100);

            table1.display();
            table2.display();
        }
    }
}
