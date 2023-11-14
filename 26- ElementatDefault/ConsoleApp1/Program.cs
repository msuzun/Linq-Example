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
            List<int> numbers = new List<int>() { 1,2,3,4,5,6,7,8,9,10};
            var x = numbers.ElementAt(8);
            var y = numbers.ElementAtOrDefault(18);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.ReadLine();
        }
    }
}
