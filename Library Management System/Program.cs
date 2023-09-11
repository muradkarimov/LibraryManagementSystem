using System;
using Library_Management_System;
using System.Text.RegularExpressions;


namespace LibraryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            string pattern = @"^[a-zA-Z0-9\s]*$";
            Regex regex = new Regex(pattern);
            Library library = new Library();
            while (true)
            {
                Console.WriteLine("Library Management System");
                Console.WriteLine("1. Add Item");
                Console.WriteLine("2. List Items");
                Console.WriteLine("3. Check Out Item");
                Console.WriteLine("4. Return Item");
                Console.WriteLine("5. Save Library Data");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
               
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter item type (Book/DVD): ");
                        string itemType = Console.ReadLine();

                        if (itemType == "Book")
                        {
                            Console.Write("Enter book title: ");
                            string bookTitle = Console.ReadLine();
                            bool isValid = regex.IsMatch(bookTitle);
                            if (!isValid)
                            {
                                Console.WriteLine("Invalid Pattern! \n" + 
                                    "Try again with correct book title!");

                                break;
                            }
                            Console.Write("Enter author: ");
                            string bookAuthor = Console.ReadLine();
                            Console.Write("Enter page count: ");
                            int pageCount = Convert.ToInt32(Console.ReadLine());
                            Book book = new Book(bookTitle, bookAuthor, ItemStatus.Available, pageCount);
                            library.AddItem(book);
                        }
                        else if (itemType == "DVD")
                        {
                            Console.Write("Enter DVD title: ");
                            string dvdTitle = Console.ReadLine();
                            bool isValid = regex.IsMatch(dvdTitle);
                            if (!isValid)
                            {
                                Console.WriteLine("Invalid Pattern! \n" +
                                    "Try again with correct dvd title!");
                                break;
                            }
                            Console.Write("Enter director: ");
                            string dvdAuthor = Console.ReadLine();
                            Console.Write("Enter run time (minutes): ");
                            int timeMinutes = Convert.ToInt32(Console.ReadLine());

                            DVD dvd = new DVD(dvdTitle, dvdAuthor, ItemStatus.Available, timeMinutes);
                            library.AddItem(dvd);
                        }
                        else
                        {
                            Console.WriteLine("Invalid item type. Please enter 'Book' or 'DVD'.");
                        }
                        break;
                    case 2:
                        library.ListItem();
                        break;
                    case 3:
                        library.CheckOutItem();
                        break;
                    case 4:
                        library.ReturnItem();
                        break;
                    case 5:
                        library.SaveItemsToFile();
                        Console.WriteLine("All items saved in text file.");
                        break;
                    case 6:
                        Console.WriteLine("Exiting the program.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                Console.WriteLine("-----------------------");
            }
            Console.ReadKey();
        }
    }
}
