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
            List<int> tempList = new List<int>();
            tempList.Add(15);
            tempList.Add(75);
            tempList.Add(55);
            tempList.Add(85);
            tempList.Add(25);
            tempList.Add(35);
            tempList.Sort();
            tempList.Reverse();

            foreach (var item in tempList)
            {
                Console.WriteLine(item);
            }
            Console.Write("Deger: ");
            short tempS = Convert.ToInt16(Console.ReadLine());
            foreach (var item in tempList.Take(tempS))
            {
                   Console.WriteLine(item);
            }
            //for (int i = 0; i < tempS; i++)
            //{
            //    Console.WriteLine(tempList[i]);
            //}
            //foreach (var item in tempList.Take(3))
            //{
            //    Console.WriteLine(item);
            //}
            Console.ReadLine();
        }
    }
}
