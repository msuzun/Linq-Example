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
            var result1 = numbers.Take(4);
            var result2 = numbers.OrderByDescending(x=>x).Take(4);
            var result3 = (from query in numbers select query).Take(4);
            var result4 = (from query in numbers select query).OrderByDescending(x=>x).Take(4);
            var result5 = numbers.Take(4).Where(x => x > 2);
            var result6 = (from query in numbers select query).Take(4).Where(x => x > 2);
            foreach (var item in result1)
            {
                Console.WriteLine(item);
            }
            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }
            foreach (var item in result3)
            {
                Console.WriteLine(item);
            }
            foreach (var item in result4)
            {
                Console.WriteLine(item);
            }
            foreach (var item in result5)
            {
                Console.WriteLine(item);
            }
            foreach (var item in result6)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
