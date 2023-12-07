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
            int[] array1 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            var grupla = from sayi in array1
                         group sayi by sayi into yenisayi
                         select yenisayi;
            foreach (var item in grupla)
            {
                Console.WriteLine("Sayim" + item.Key + " " +item.Count() + " kere gözüktü");
            }
            Console.ReadLine();
        }
    }
}
