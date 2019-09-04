using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap41
{

    public string Name { get; set; }
    public string ReleasedDate { get; set; }
    public string Nickname { get; set; }

    class Book
    {
    }

    public Book(string name, string releasedDate, string nickname)
    {
        this.Name = name;
        this.ReleasedDate = releasedDate;
        this.Nickname = nickname;
    }
}
