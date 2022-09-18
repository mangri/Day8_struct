using System;

namespace structMokinys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mokinys mokinys = new Mokinys("Petras", "Petraitis", 
                DateTime.Parse("2022-09-05"), DateTime.Parse("2022-09-05").AddMonths(6));
            mokinys.printMokinys();
        }
        struct Mokinys
        {
            public string FirstName;
            public string LastName;
            public DateTime CourseStart;
            DateTime CourseEnd;
            public Mokinys(string firstName, string lastName, DateTime courseStart, DateTime courseEnd)
            {
                FirstName = firstName;
                LastName = lastName;
                CourseStart = courseStart;
                CourseEnd = courseEnd;
            }
            public void printMokinys()
            {
                Console.WriteLine(FirstName);
                Console.WriteLine(LastName);
                Console.WriteLine(CourseStart);
                Console.WriteLine(CourseEnd);
            }
        }
        
    }
}
