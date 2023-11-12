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
            List<string> isimler = new List<string>();
            isimler.Add("Sevki");
            isimler.Add("Muhammet");
            isimler.Add("İbrahim");
            isimler.Add("Mustafa");

            var result=isimler.Contains("Mustafa");
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
