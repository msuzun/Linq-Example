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
            string[] employeesNames = { "Asutosh", "Kapil", "Sumit", "Rajat", "Preeti", "Sumit", "Kanupriya", "Kapil" };
            var distinctEmployees = employeesNames.Distinct();
            foreach (var item in distinctEmployees)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
