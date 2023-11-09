using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
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
            // 1 . yöntem Query Syntax
            List<Student> students = new List<Student>();
            students.Add(new Student
            {
                Id = 1,
                Name = "Muhammet",
            });
            students.Add(new Student
            {
                Id = 2,
                Name = "Şevki"
            });
            students.Add(new Student
            {
                Id = 3,
                Name = "İbrahim"
            });
            var result = from s in students
                         where s.Name.Contains("Ş")
                         select s.Name;
            Console.WriteLine(result.FirstOrDefault());
        }
        static void MethodSyntax()
        {
            // 1 . yöntem Query Syntax
            List<Student> students = new List<Student>();
            students.Add(new Student
            {
                Id = 1,
                Name = "Muhammet",
            });
            students.Add(new Student
            {
                Id = 2,
                Name = "Şevki"
            });
            students.Add(new Student
            {
                Id = 3,
                Name = "İbrahim"
            });
            var result = students.Where(x => x.Name.Contains("Ş")).Select(c => c.Name);
            Console.WriteLine(result.FirstOrDefault());
        }
    }
   
}
