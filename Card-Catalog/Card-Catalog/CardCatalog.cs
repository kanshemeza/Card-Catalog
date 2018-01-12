using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace Card_Catalog
{
    public class CardCatalog
    {

        private string _filename;
        private List<Book> books = new List<Book>();      //This is the private member variable that contains all of the books

        
        public CardCatalog(string fileName)
        {/*code goes here*/
            _filename = fileName;

            books.Add(new Book() { Author = "Amon", Title = "Learning C#", ISBN = "12345" });
            books.Add(new Book() { Author = "Jim", Title = "Learning C#", ISBN = "67890" });
            books.Add(new Book() { Author = "Joe", Title = "Teaching C#", ISBN = "246810" });
        }


        //Deserializing the "test.xml" file into the List<Book> object
        public List<Book> ListBooks()
        {
            
            XmlSerializer serializer = new XmlSerializer(typeof(List<Book>));
            TextReader reader = new StreamReader("test.xml");
            List<Book> books = null;
            books = serializer.Deserialize(reader) as List<Book>;
            return books;
            
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

        //Serializing the List<Book> collection into an XML file
        public void Save()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Book>));
            using (TextWriter writer = new StreamWriter("test.xml"))
            {
                serializer.Serialize(writer, books);
    }

        }

    }
}

