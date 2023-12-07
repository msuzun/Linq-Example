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
            //IEnumerable<int> number = Enumerable.Range(1, 10);
            //IEnumerable<int> number = Enumerable.Range(1, 30).Where(sayi=>sayi %2 ==0);
            IEnumerable<int> number = Enumerable.Range(1, 30).Select(sayi => sayi*sayi);
            foreach (int i in number) { Console.WriteLine(i); };
            Console.ReadLine();
        }
    }
}
