using System;
using System.Linq;

namespace structStudentGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] semester1 = new int[] { 7, 8, 9 };
            int[] semester2 = new int[] { 8, 9, 10 };
            int[] semester3 = new int[] { 10, 10, 10 };
            Studentas Stud1 = new Studentas(semester1, semester2, semester3);
            (double avgSem1, double avgSem2, double avgSem3) = Stud1.avgSem(semester1, semester2, semester3);
            double avgAn1 = Stud1.avgAn(semester1, semester2, semester3);
            Console.WriteLine("Semester results: {0:0.0}, {1:0.0}, {2:0.0}", avgSem1, avgSem2, avgSem3);
            Console.WriteLine("The final mark: {0:0.0}", avgAn1);
            Console.ReadLine();

        }
        struct Studentas
        {
            public int[] Semester1;
            public int[] Semester2;
            public int[] Semester3;
            public Studentas(int[] semester1, int[] semester2, int[] semester3)
            {
                Semester1 = semester1;
                Semester2 = semester2;
                Semester3 = semester3;
            }
            public (double, double, double) avgSem(int[] semester1, int[] semester2, int[] semester3)
            {
                return (semester1.Average(), semester2.Average(), semester3.Average());
            }
            public double avgAn(int[] semester1, int[] semester2, int[] semester3)
            {
                return ((semester1.Average() + semester2.Average() + semester3.Average())/3);
            }
        }
    }
}
