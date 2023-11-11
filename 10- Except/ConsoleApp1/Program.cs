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
            string[] Array1 = { "Ramesh", "Kapil", "Vikas", "Amit" };
            string[] Array2 = { "Kapil", "Manmohan", "Deepak", "Amit" };
            var fark = Array1.Except(Array2);
            Console.WriteLine("Fark : ");
            foreach (var item in fark)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
