using System;

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
            CardCatalog Test = new CardCatalog("woodowrth.xml");
            Console.WriteLine();
            int menuOption = 0;
            while (menuOption != 3)
            {
                Console.WriteLine("Main Menu: ");
                Console.WriteLine("  [1] List All Books ");
                Console.WriteLine("  [2] Add A Book ");
                Console.WriteLine("  [3] Save and Exit");
                Console.WriteLine("Please select an option from the menu above: ");
                menuOption = Convert.ToInt32(Console.ReadLine());
                Console.ReadLine();
                Test.ListBooks();
                
                Test.AddBook();
                Test.Save();


            }
 
        }
    }
}
