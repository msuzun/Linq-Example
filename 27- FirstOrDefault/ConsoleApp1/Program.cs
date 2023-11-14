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
            List<int> number = new List<int>() { 1,2,3,4,5,6,7,8,9};
          
            var x = number.First();
            var y = number.First(z=>z%2==0);
            var k = number.FirstOrDefault(q=>q>50);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(k);
            Console.ReadLine();
        }
    }
}
