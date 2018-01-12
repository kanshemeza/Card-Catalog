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
            ISBN = "000";
        }

        public Book(string title, string author, string iSBN) : base()
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
        }

        //public override string ToString()
        //{
        //    return "Book: " + Title + "   Author: " + Author;
        //}
        //public override bool Equals(object obj)
        //{
        //    if (obj == null) return false;
        //    Book objAsBook = obj as Book;
        //    if (objAsBook == null) return false;
        //    else return Equals(objAsBook);
        //}
        //public override int GetHashCode()
        //{
        //    return 0;
        //}
        //public bool Equals(Book other)
        //{
        //    if (other == null) return false;
        //    return (this.ISBN.Equals(other.ISBN));
        //}

    }
}
