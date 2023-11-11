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
            int[] intArray = new int[] { 10,30,50,40,60,20,70,100};
            Console.WriteLine("Reverse metodunu kullanmadan önce");
            foreach (var item in intArray)
            {
                Console.Write(item+ " ");
            }

            var ArrayReversedData = intArray.Reverse();
            Console.WriteLine("\nReverse metodunu kullandıktan sonra");
            foreach (var item in ArrayReversedData)
            {
                Console.Write(item+ " ");
            }
            Console.ReadLine();
        }
    }
}
