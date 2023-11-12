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
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student { Id = 1, Name = "Asutosh", IsFeesSubmitted = true });
            students.Add(new Student { Id = 2, Name = "Kapil", IsFeesSubmitted = true });
            students.Add(new Student { Id = 3, Name = "Sumit", IsFeesSubmitted = true });
            students.Add(new Student { Id = 4, Name = "Rajat", IsFeesSubmitted = false });
            students.Add(new Student { Id = 5, Name = "Preeti", IsFeesSubmitted = true });
            students.Add(new Student { Id = 6, Name = "Kanupriya", IsFeesSubmitted = true });

            //check whether all students submitted their fees or not
            bool areAllStudentsSubmitTheirFees = students.All(student => student.IsFeesSubmitted == true);
            Console.WriteLine(areAllStudentsSubmitTheirFees);
            Console.ReadLine();
        }
    }
}
