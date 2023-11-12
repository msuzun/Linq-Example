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
        public bool IsFeesSubmitted { get; set; }
        public int Age { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ornek1();
            Ornek2();
        }

        private static void Ornek2()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student { Id = 1, Name = "Kapil", Age = 22 });
            students.Add(new Student { Id = 2, Name = "Ramesh", Age = 17 });
            students.Add(new Student { Id = 3, Name = "Raj", Age = 24 });
            students.Add(new Student { Id = 4, Name = "Anil", Age = 25 });

            if (students.Any(x=>x.Age < 18))
            {
                Console.WriteLine("Objemizde 18 yasindan kucuk elemanlar vardir");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Bu kosulda kayıt yok");
                Console.ReadLine();
            }
            
        }

        private static void Ornek1()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student { Id = 1, Name = "Sevki", IsFeesSubmitted = false });
            if (students.Any())
            {
                Console.WriteLine("Elemean var");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Hiç eleman yok");
                Console.ReadLine();
            }
        }
    }
}
