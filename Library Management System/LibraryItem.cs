using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{

    enum ItemStatus { Available, CheckedOut}
    internal  class LibraryItem: Display
    {
        public string Title;
        public string Author;
        public ItemStatus Status;
        public LibraryItem(string Title, string Author, ItemStatus Status)
        {
            this.Title = Title;
            this.Author = Author;
            this.Status = Status;
        }

        public string Context()
        {
           return $"Title: {Title},\n"+
                $"Author: {Author},\n"+
                $"Status: {Status},\n";
        }
        public virtual void DisplayInfo() {
            Console.WriteLine(Context());
        }

    }
}
