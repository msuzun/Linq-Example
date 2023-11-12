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

            var result1 = students.GroupBy(x => x.Branch);
            var result2 = from x in students group x by x.Branch; //QuerySyntax
            foreach (var item in result2)
            {
                Console.WriteLine(item.Key+ " :"+item.Count());
                foreach (var item1 in item)
                {
                    Console.WriteLine("Name : " + item1.Name + " ,Age : " + item1.Age + " ,Gender : " + item1.Gender);
                }
            }
            Console.ReadLine();
        }
    }
}
