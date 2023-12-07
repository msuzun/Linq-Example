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
            int[] numberSequence = { 10, 20, 30, 40, 50 };
            string[] stringSequence = { "Ten", "Twenty", "Thirty", "Fourty" };

            var result = numberSequence.Zip(stringSequence, (x, y) => x + "-" + y);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
