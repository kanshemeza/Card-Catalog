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


        public CardCatalog()
        {
        }
        public CardCatalog(string fileName)
        {/*code goes here*/
            _filename = fileName;
            books = DeserializerMthd(_filename);
            //test data to load into book generic collection
            //books.Add(new Book() { Author = "Amon", Title = "Learning C#", ISBN = "12345" });
            //books.Add(new Book() { Author = "Jim", Title = "Learning C#", ISBN = "67890" });
            //books.Add(new Book() { Author = "Joe", Title = "Teaching C#", ISBN = "246810" });
        }


        //method to list books in gneric collection
        public void ListBooks()
        {
            if (books.Count > 0)
            {
                foreach (Book abook in books)
                {
                    Console.WriteLine("Title:  {0} \t \t Author: {1} \t \t ISBN: {2}", abook.Title, abook.Author, abook.ISBN);
                }
            }
            else
            {
                Console.WriteLine("No books in catalog");
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
        }

        //Serializing the List<Book> collection into an XML file
        public void Save()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Book>));
            using (TextWriter writer = new StreamWriter(_filename))
            {
                serializer.Serialize(writer, books);
            }
        }

        public List<Book> DeserializerMthd(string filename)
        {
            if(File.Exists(filename))
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(List<Book>));
                TextReader reader = new StreamReader(filename);
                List<Book> books = null;
                books = deserializer.Deserialize(reader) as List<Book>;
                reader.Close();
                return books;
            }
            else
            {
                return books;
            }

        }
    }
}

