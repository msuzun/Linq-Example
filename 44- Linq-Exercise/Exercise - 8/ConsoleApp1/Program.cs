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
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS"};
            string baslangic, bitis;
            Console.WriteLine("Başlangıç karakteri giriniz");
            baslangic = Console.ReadLine();
            Console.WriteLine("Bitiş karakteri giriniz");
            bitis = Console.ReadLine();

            var result = from x in cities where x.ToLower().StartsWith(baslangic) where x.ToLower().EndsWith(bitis) select x;
            foreach (var item in result)
            {
                Console.WriteLine($"{baslangic} ile başlayan  ve {bitis} ile biten şehrimiz:  {item}");
            }
            Console.ReadLine();
        }
    }
}
