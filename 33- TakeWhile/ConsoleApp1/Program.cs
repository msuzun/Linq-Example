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
            List<int> numbers = new List<int>() { 1,2,3,6,7,8,9,10, 4, 5 };
           var resultMS = numbers.TakeWhile(num=> num <6);

            foreach (var item in resultMS)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
