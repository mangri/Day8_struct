using System;
using System.Collections.Generic;
using static structStudentList.Program;

namespace structStudentList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Adding five students to the list StudentList
            List<Student> StudentList = new List<Student>();

            Student student1 = new Student("PoPeYe314", true);
            Student student2 = new Student("Tulipo215", true);
            Student student3 = new Student("Salala777", true);
            Student student4 = new Student("Tartar046", false);
            Student student5 = new Student("Megalo666", false);

            StudentList.Add(student1);
            StudentList.Add(student2);
            StudentList.Add(student3);
            StudentList.Add(student4);
            StudentList.Add(student5);

            showingStudents(StudentList);
            

        }
        public struct Student
        {
            public string Id;
            public bool ExamPass;


            public Student(string id, bool examPass)
            {
                Id = id;
                ExamPass = examPass;
            }
            

        }
        static void showingStudents(List<Student> StudentList)
        {

            
            foreach (Student student in StudentList)
            {
                Console.Write(student.Id);
                Console.Write(student.ExamPass);
                Console.WriteLine();
            }

        }


    }
}
