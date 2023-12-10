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
            int[] dizim = new int[]{ 5,1,9,2,3,7,4,5,6,8,7,6,3,4,5,2};
            var result = from x in dizim group x by x into y select y;
            foreach (var item in result)
            {
                Console.WriteLine("Sayi: " + item.Key + " Sayi*Frequency: "+ item.Sum()+" Frequency: "+item.Count());
            }
            Console.ReadLine();
        }
    }
}
