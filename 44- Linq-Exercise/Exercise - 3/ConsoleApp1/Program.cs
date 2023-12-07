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
            var array1 = new[] { 3, 5, 7, 9 };
            var result = from sayi in array1
                         let result2 = sayi * sayi
                         where result2 > 10
                         select new { sayi, result2 };
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
