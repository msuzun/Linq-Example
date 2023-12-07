using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { -8, -9, 3, 9, 45, -4, 84, 14, 1, -98};
            var maks = numbers.Max();
            var result = from sayi in numbers where sayi > 0 where sayi <= maks select sayi;
            foreach (var item in result)
            {
                Console.WriteLine(item);   
            }
            Console.ReadLine();
        }
    }
}
