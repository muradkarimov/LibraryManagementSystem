using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class DVD: LibraryItem
    {
        private int TimeMinute;
        public DVD(string Title, string Author, ItemStatus Status, int TimeMinute) : base(Title, Author, Status)
        {
            this.TimeMinute = TimeMinute;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"{Context()}" +
                $"Time in minutes: {TimeMinute}"
                );
        }
    }
}
