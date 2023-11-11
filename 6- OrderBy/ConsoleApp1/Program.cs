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
            students.Add(new Student { Id = 1, Name = "Ramesh", Rank = 3 });
            students.Add(new Student { Id = 2, Name = "Kapil", Rank = 1 });
            students.Add(new Student { Id = 3, Name = "Suresh", Rank = 2 });

            //var studentOrderByRank = students.OrderBy(x => x.Rank);
            var studentOrderDescendingByRank = students.OrderByDescending(x => x.Rank);
            Console.WriteLine("Sorted Students: ");
            foreach (var student in studentOrderDescendingByRank)
            {
                Console.WriteLine(student.Name);
            }
        }

        private static void QuerySyntax()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student { Id = 1, Name = "Ramesh", Rank = 3 });
            students.Add(new Student { Id = 2, Name = "Kapil", Rank = 1 });
            students.Add(new Student { Id = 3, Name = "Suresh", Rank = 2 });

            var studentOrderByRank = from student in students
                                     orderby student.Rank
                                     select student;
            Console.WriteLine("Sorted Students: ");
            foreach (var student in studentOrderByRank)
            {
                Console.WriteLine(student.Name);
            }
        }
    }
}
