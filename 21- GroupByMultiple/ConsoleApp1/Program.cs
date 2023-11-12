using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Branch { get; set; }
        public int Age { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>() {
                new Student{ Id = 1001, Name = "Preety", Gender = "Female", Branch = "CSE", Age=20 },
                new Student{ Id = 1002, Name = "Snurag", Gender = "Male", Branch = "ETC", Age=21 },
                new Student{ Id = 1003, Name = "Pranaya", Gender = "Male", Branch = "CSE", Age=21 },
                new Student{ Id = 1004, Name = "Anurag", Gender = "Male", Branch = "CSE", Age=20 },
                new Student{ Id = 1005, Name = "Hina", Gender = "Female", Branch = "CSE", Age=20 },
                new Student{ Id = 1006, Name = "Priyanka", Gender = "Female", Branch = "CSE", Age=21 },
                new Student{ Id = 1007, Name = "Santosh", Gender = "Male", Branch = "CSE", Age=22 },
                new Student{ Id = 1008, Name = "Tina", Gender = "Female", Branch = "CSE", Age=20 },
                new Student{ Id = 1009, Name = "Celina", Gender = "Female", Branch = "ETC", Age=22 },
                new Student{ Id = 1010, Name = "Sambit", Gender = "Male", Branch = "ETC", Age=21 },
            };
            //Method Syntax
            var result1 = students.GroupBy(x => new { x.Branch, x.Gender }).OrderByDescending(y => y.Key.Branch).ThenBy(y => y.Key.Gender).Select(y => 
            new {
                Branch = y.Key.Branch,
                Gender = y.Key.Gender,
                Students = y.OrderBy(x=>x.Name)});

            //Query Syntax
            var result2 = from x in students
                          group x by
                          new { x.Branch, x.Gender }
                          into y
                          orderby y.Key.Branch descending,
                          y.Key.Gender ascending
                          select new
                          {
                              Branch2 = y.Key.Branch,
                              Gender2 = y.Key.Gender,
                              Students2 = y.OrderBy(x => x.Name)
                          };

            foreach (var item in result2)
            {
                Console.WriteLine("Branch: "+item.Branch2 + " Gender: "+item.Gender2);
                foreach (var item1 in item.Students2)
                {
                    Console.WriteLine("Id: " + item1.Id + " Name: " + item1.Name + " Age : " + item1.Age);
                }
            }
            Console.ReadLine();
        }
    }
}
