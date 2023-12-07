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
            string str1;
            Console.WriteLine("Bir kelime girin");
            str1 = Console.ReadLine();
            var result = from stryeni in str1 group stryeni by stryeni into sonuc select sonuc;

            foreach (var item in result)
            {
                Console.WriteLine("Karater "+ item.Key + " "+ item.Count()+ " kere");
            }
            Console.ReadLine();
        }
    }
}
