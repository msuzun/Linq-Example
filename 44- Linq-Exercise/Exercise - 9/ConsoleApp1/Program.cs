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
            tempList.Add(55);
            tempList.Add(200);
            tempList.Add(155);
            tempList.Add(51);
            tempList.Add(95);
            tempList.Add(498);
            tempList.Add(53);

            //var result = tempList.Where(x => x > 80);
            var result = tempList.FindAll(x=>x>80 ? true : false);

            foreach (var item in result) 
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
