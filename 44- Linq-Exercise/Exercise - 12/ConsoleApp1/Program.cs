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
            string tempS;
            Console.WriteLine("Bir cumle giriniz");
            tempS = Console.ReadLine();

            var tempS2 = FindUpperWord(tempS);
            Console.WriteLine("Girmiş olduğunuz cümledeki büyük kelimeler");
            foreach (var item in tempS2)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
        private static IEnumerable<string> FindUpperWord(string s) 
        {
           var result = s.Split(' ').Where(x=>string.Equals(x,x.ToUpper()));
            return result;
        }
    }
}
