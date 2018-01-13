using System;
using System.Collections.Generic;
using System.Text;

namespace Card_Catalog
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        public Book()
        {
        
        }

        public Book(string title, string author, string iSBN) : base()
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
        }
    }
}
