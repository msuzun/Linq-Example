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
            int[] array1 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var result1 = from sayi in array1 where sayi % 2 == 0 select sayi; // query syntax
            var result2 = array1.Where(sayi=>sayi % 2 == 0); // method syntax
            foreach (var item in result2)
            {
                Console.Write("{0} ",item);
            }
            Console.ReadLine();
        }
    }
}
