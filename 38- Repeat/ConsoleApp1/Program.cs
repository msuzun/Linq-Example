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
            IEnumerable<String> str2 = Enumerable.Repeat("MSuzun", 10);
            foreach (String str in str2) { Console.WriteLine(str); }
            Console.ReadLine();
        }
    }
}
