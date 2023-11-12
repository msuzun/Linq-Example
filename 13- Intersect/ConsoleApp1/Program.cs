using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] employeesInDepthA = { "Asutosh", "Kapil", "Sumit", "Rajat" };
            string[] employeesInDepthB = { "Preeti", "Sumit", "Kanupriya", "Kapil" };
            var result = employeesInDepthA.Intersect(employeesInDepthB);
            Console.WriteLine("Common Employees in Department A and B");
            foreach (var employee in result) 
            { 
                Console.WriteLine(employee);
            }
            Console.ReadLine();
        }
    }
}
