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
            List<int> numbers = new List<int>() { 1,2,3,4,5,6,7,8,9,10};
            //var result = numbers.Skip(4);
            //var result = numbers.Where(x => x > 3).Skip(4);
            //var result = numbers.Skip(4).Where(x => x < 8);
            var result = (from x in numbers select x).Skip(4).Where(y=>y<8);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
