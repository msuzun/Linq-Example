using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Course
    {
        public int ID { get; set; }
        public string Subject { get; set; }
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
        static void QuerySyntax()
        {
            List<Course> courses = new List<Course>();
            courses.Add(new Course()
            {
                ID = 1,
                Subject = "LINQ Tutorials",
                Rank = 5,
            });
            courses.Add(new Course()
            {
                ID = 2,
                Subject = ".NET Threading Tutorials",
                Rank = 4,
            });
            courses.Add(new Course()
            {
                ID = 3,
                Subject = "Learn WPF",
                Rank = 3,
            });
            var result = from course in courses
                         where course.Rank > 3 && course.Subject.Contains("Threading")
                         select course;
            foreach (var course in result)
            {
                Console.WriteLine(course.Subject);
            }
        }
        static void MethodSyntax()
        {
            List<Course> courses = new List<Course>();
            courses.Add(new Course()
            {
                ID = 1,
                Subject = "LINQ Tutorials",
                Rank = 5,
            });
            courses.Add(new Course()
            {
                ID = 2,
                Subject = ".NET Threading Tutorials",
                Rank = 4,
            });
            courses.Add(new Course()
            {
                ID = 3,
                Subject = "Learn WPF",
                Rank = 3,
            });
            var result = courses.Where(x => x.Rank > 3 && x.Subject.Contains("Threading"));
            foreach (var course in result)
            {
                Console.WriteLine(course.Subject);
            }
        }
    }
}
