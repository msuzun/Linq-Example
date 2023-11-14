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
            List<int> numbers = new List<int>() { 10,20,30};
            var x = numbers.Single(y=>y==20);
            var z = numbers.SingleOrDefault(q=>q>40);
            Console.WriteLine(x);
            Console.WriteLine(z);
            Console.ReadLine();
        }
    }
}
