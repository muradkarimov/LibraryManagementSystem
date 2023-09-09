using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class Library
    {
        private List<LibraryItem> items = new List<LibraryItem>();
        //string pattern = "^[a-zA-Z0-9]+$";
        //Regex regex  = new Regex(pattern);
        public void AddItem(LibraryItem item)
        {
            if (items.Contains(item))
            {
                Console.WriteLine($"{item.Title} by {item.Author} is already in the library.");
            }
            else { items.Add(item);
                Console.WriteLine($"{item.Title} by {item.Author} added to the library.");
            }
        }
        public void ListItem() {
            Console.WriteLine("Library Items:");
            foreach (var item in items)
            {
                item.DisplayInfo();
                Console.WriteLine();
            }
        }
       
        public void CheckOutItem()
        {
            Console.Write("Enter name: ");
            string title = Console.ReadLine();
            List<string> names = new List<string>();
            foreach (var item in items)
            {
                names.Add(item.Title);
                if (item.Title == title)
                {
                    if (item.Status == ItemStatus.Available)
                    {
                        item.Status = ItemStatus.CheckedOut;
                        Console.WriteLine($"{item.Title} has been checked out.");
                    }
                    else
                    {
                        Console.WriteLine($"{item.Title} is already checked out.");
                    }
                    break;
                }
               
            }
            if (!names.Contains(title))
            {
                Console.WriteLine($"{title} is not in the library.");
            }
        }


        public void ReturnItem()
        {
            Console.Write("Enter name: ");
            string title = Console.ReadLine();
            List<string> names = new List<string>();
            foreach (var item in items)
            {
                names.Add(item.Title);
                if (item.Title == title)
                {
                    Console.WriteLine($"{item.Title} has been returned.");
                    item.Status = ItemStatus.Available;
                    break;
                }
            }
            if (!names.Contains(title))
            {
                Console.WriteLine($"{title} is not in the library.");
            }
        }


        public void SaveItemsToFile()
        {
            string directoryPath = @"H:\console_app_csharp";
            string fileName = "libraryData.txt";
            string filePath = Path.Combine(directoryPath, fileName);
            try
            {
                Directory.CreateDirectory(directoryPath);
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine(items);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occured: {0}", ex.Message);
            }
            //foreach (var item in items)
            //{
            //    string directoryPath = @"H:\console_app_csharp";
            //    string fileName = "libraryData.txt";
            //    string filePath = Path.Combine(directoryPath, fileName);
            //    try
            //    {
            //        Directory.CreateDirectory(directoryPath);
            //        using (StreamWriter writer = new StreamWriter(filePath))
            //        {
            //            writer.WriteLine($"Title: {item.Title},\n" +
            //    $"Author: {item.Author},\n" +
            //    $"Status: {item.Status}\n");
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine("An error occured: {0}", ex.Message);
            //    }
            //}

        }
    }
}
