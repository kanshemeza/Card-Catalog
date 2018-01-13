using System;
using System.IO;
using System.Xml.Serialization;

namespace Card_Catalog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Amon and Jim Card Catalog");
            Console.WriteLine();
            Console.WriteLine("Please enter the filename for the card catalog: ");
            string filename = Console.ReadLine();

            //test to see if file exists
            if (!File.Exists(filename))
            {
                Console.WriteLine("File does not exist. Starting new catalog");
            }

            //create card catalog
            CardCatalog CurrentCatalog = new CardCatalog(filename);
                        
            Console.WriteLine();
            int menuOption = 0;

            //while loop for menu listing
            while (menuOption != 3)
            {
                Console.WriteLine("Main Menu: ");
                Console.WriteLine("  [1] List All Books ");
                Console.WriteLine("  [2] Add A Book ");
                Console.WriteLine("  [3] Save and Exit");
                Console.WriteLine("Please select an option from the menu above: ");
            
                //Amon we might want to chnage this to a int.tryparse to keep progrma from blowing up
                menuOption = Convert.ToInt32(Console.ReadLine());

                if (menuOption == 1)
                {
                    CurrentCatalog.ListBooks();
                }
                else if (menuOption == 2)
                {
                    CurrentCatalog.AddBook();
                }
                else if (menuOption == 3)
                {
                    CurrentCatalog.Save();
                    Console.WriteLine("{0} Saved", filename);
                    Console.WriteLine("Please press enter to exit");
                    Console.ReadLine();
                    Environment.Exit(0);
                }

            }
 
        }
    }
}
