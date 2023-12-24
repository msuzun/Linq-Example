using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dirFiles = Directory.GetFiles(@"C:\");
            var avgFsize = dirFiles.Select(x => new FileInfo(x).Length).Average();
            avgFsize = Math.Round(avgFsize/10,1);
            Console.WriteLine(avgFsize.ToString());
        }
    }
}
