using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class Book: LibraryItem
    {
        private int PageCount;
        public Book(string Title, string Author,ItemStatus Status, int PageCount) : base(Title, Author, Status)
        {
            this.PageCount = PageCount;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"{Context()}"+
                $"Page Count: {PageCount}"
                );
        }
    }
}
