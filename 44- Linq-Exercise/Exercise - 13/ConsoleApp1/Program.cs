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
            string[] array1;
            int n;
            Console.WriteLine("Dizi elemanının kaç elemanlı olacagini giriniz");
            n = Convert.ToInt32(Console.ReadLine());
            array1 = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Eleman {0}", i + 1);
                array1[i] = Console.ReadLine();
            }
            string newString = string.Join(",", array1.Select(x=>x.ToString().ToArray()));
            Console.WriteLine(newString);
            Console.ReadLine();
        }
    }
}
