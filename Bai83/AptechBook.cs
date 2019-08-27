using System;
using System.Collections.Generic;
using System.Text;

namespace Bai83
{
    public class AptechBook
    {
        private String language { get; set; }

        private int semester { get; set; }

        private AptechBook(){

        }

        private AptechBook(string language, int semester)
        {
            this.language = language;
            this.semester = semester;
        }


    }
}
