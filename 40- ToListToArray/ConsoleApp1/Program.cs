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
            //int[] array1 = { 10, 11, 54, 68, 74, 16 };
            //List<int> numberList = array1.ToList();
            //foreach (var item in numberList)
            //{
            //    Console.WriteLine(item);
            //}
            List<int> list1 = new List<int>{ 10, 11, 54, 68, 74, 16 };
            int[] array2 = list1.ToArray();
            foreach (var item in array2)
            {
                  Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
