using System;
using System.Collections.Generic;
using System.Text;

namespace Card_Catalog
{
    public class CardCatalog
    {

        private string _filename { get; set; }
        private List<Book> books = new List<Book>();      //This is the private member variable that contains all of the books


        public CardCatalog(string fileName)
        {/*code goes here*/
            books.Add(new Book() { Author = "Amon", Title = "Learning C#", ISBN = "12345" });
            books.Add(new Book() { Author = "Jim", Title = "Learning C#", ISBN = "67890" });
            books.Add(new Book() { Author = "Joe", Title = "Teaching C#", ISBN = "246810" });
        }

        public void ListBooks()
        {
            foreach(Book aBook in books)
            {
                Console.WriteLine("Author:  {0} \t Title: {1} \t \t     ISBN: {2}", aBook.Author, aBook.Title, aBook.ISBN);
            }
        }

        public void AddBook()
        {/*code goes here*/
            Book temp = new Book();
            Console.Clear();
            Console.WriteLine("Adding Book To Catalog");
            Console.WriteLine();
            Console.WriteLine("Please enter the Title of the book: ");
            temp.Title = Console.ReadLine();
            Console.WriteLine("Please enter the Author of the book: ");
            temp.Author = Console.ReadLine();
            Console.WriteLine("Please enter the ISBN of the book: ");
            temp.ISBN = Console.ReadLine();
            books.Add(temp);
            ListBooks();

        }

        //public ?? Save(??)
        //{/*code goes here*/
        //}

    }
}

