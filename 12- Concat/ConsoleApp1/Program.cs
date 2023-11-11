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
            List<int> sequence1 = new List<int> { 1,2,3,4};
            List<int> sequence2 = new List<int> { 2,4,6,8};
            var result = sequence1.Concat(sequence2);
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\nContat- Union farkı");
            var result2 = sequence1.Union(sequence2);
            foreach (var item in result2)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }
    }
}
