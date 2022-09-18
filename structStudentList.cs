using System;
using System.Collections.Generic;

namespace structStudentList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Adding five students to the list StudentList
            List<string> StudentList = new List<string>();
            for(int i = 1; i < 6; i++)
            {
                StudentList.Add("Student" + Convert.ToString(i));
            }
            //Putting student IDs and results
            Student Student1 = new Student("PoPeYe314", true);
            Student Student2 = new Student("Tulipo215", true);
            Student Student3 = new Student("Salala777", true);
            Student Student4 = new Student("Tartar046", false);
            Student Student5 = new Student("Megalo666", false);
            //Printing student info
            showingStudents(StudentList);
            

        }
        struct Student
        {
            public string Id;
            public bool ExamPass;


            public Student(string id, bool examPass)
            {
                Id = id;
                ExamPass = examPass;
            }
        }
        static void showingStudents(List<string> StudentList)
        {
            Console.WriteLine("Here is the student list:");
            foreach(var st in StudentList)
            {
                Console.WriteLine(st);
            }
        }
    }
}
