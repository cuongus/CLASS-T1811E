using System;
using System.Collections.Generic;

namespace bt41
{
    class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<Author> listAuthor = new List<Author>();

            for(int i =0; i<3; i++)
            {
                Author author = new Author();
                author.Input();
                listAuthor.Add(author);
            }
        }
    }
}
