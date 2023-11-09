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
            
            List<string> countries = new List<string>();
            countries.Add("India");
            countries.Add("USA");
            countries.Add("UK");
            foreach (var country in countries)
            {
                Console.WriteLine(country);
            }
        }
    }
}
