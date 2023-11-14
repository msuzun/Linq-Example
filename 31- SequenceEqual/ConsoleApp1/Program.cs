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
            List<string> cityList1 = new List<string>() { "Delhi","Mumbai","Hyderabad"};
           
            List<string> cityList2 = new List<string>() { "Delhi", "Mumbai", "Hyderabad" };
            List<string> cityList3 = new List<string>() { "Delhi", "mumbai", "Hyderabad" };
            List<string> cityList4 = new List<string>() { "delhi", "mumbai", "Hyderabad" };
            List<string> cityList5 = new List<string>() { "Hyderabad", "Mumbai", "Delhi" };
            bool x = cityList1.SequenceEqual(cityList2);
            bool y = cityList2.SequenceEqual(cityList3);
            bool z = cityList1.SequenceEqual(cityList4,StringComparer.OrdinalIgnoreCase);
            bool h = cityList1.OrderBy(q=>q).SequenceEqual(cityList5.OrderBy(k=>k));
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(h);
            Console.ReadLine();
        }
    }
}
