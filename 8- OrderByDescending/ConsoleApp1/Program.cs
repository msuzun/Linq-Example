using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Rank { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //QuerySyntax();
            MethodSyntax();
            Console.ReadLine();
        }

        private static void MethodSyntax()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student { Id = 1, Name = "Ramesh", Rank = 1, Age = 39 });
            students.Add(new Student { Id = 2, Name = "Kapil", Rank = 1, Age = 32 });
            students.Add(new Student { Id = 3, Name = "Suresh", Rank = 2, Age = 45 });
            students.Add(new Student { Id = 4, Name = "Mahesh", Rank = 2, Age = 39 });

            var studentsOrderByRank = students.OrderByDescending(x=>x.Rank);
            Console.WriteLine("Sorted Students : ");
            foreach (var student in studentsOrderByRank)
            {
                Console.WriteLine(student.Name);
            }
        }

        private static void QuerySyntax()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student { Id = 1, Name = "Ramesh", Rank = 1, Age = 39 });
            students.Add(new Student { Id = 2, Name = "Kapil", Rank = 1, Age = 32 });
            students.Add(new Student { Id = 3, Name = "Suresh", Rank = 2, Age = 45 });
            students.Add(new Student { Id = 4, Name = "Mahesh", Rank = 2, Age = 39 });

            var studentsOrderByRank = from student in students
                                      orderby student.Rank descending
                                      select student;
            Console.WriteLine("Sorted Students : ");
            foreach (var student in studentsOrderByRank)
            {
                Console.WriteLine(student.Name);
            }
        }
    }
}
