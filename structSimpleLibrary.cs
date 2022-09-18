using System;

namespace structSimpleLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LibraryBook Book1 = new LibraryBook("MB1851", "The Whale", "Kindziulis",
                DateTime.Parse("2022-09-05 15:20"));
            Console.WriteLine($"{Book1.StudentName} has \"{Book1.BookTitle}\" for {Book1.readingDays().Days} days");
        }
        struct LibraryBook
        {
            public string BookID;
            public string BookTitle;
            public string StudentName;
            public DateTime LendDate;
            public LibraryBook(string bookID, string bookTitle, string studentName, DateTime lendDate)
            {
                BookID = bookID;
                BookTitle = bookTitle;
                StudentName = studentName;
                LendDate = lendDate;
            }
            public TimeSpan readingDays()
            {
                return DateTime.Now - LendDate;
            }
        }

    }
}
