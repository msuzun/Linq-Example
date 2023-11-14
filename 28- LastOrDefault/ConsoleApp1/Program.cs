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
            List<int> numbers = new List<int>() { 1,2,3,4,5,6,7,8,9};
            var x = numbers.Last();
            var y = numbers.LastOrDefault(z=>z>50);
            var query= (from q in numbers select q).LastOrDefault();
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(query);
            Console.ReadLine();
        }
    }
}
