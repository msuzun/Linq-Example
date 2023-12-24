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
            string[] arr1 = { "aaa.frx", "bbb.TXT", "xyz.dbf", "abc.pdf", "aaaa.PDF", "xyz.frt", "abc.xml", "ccc.txt", "zzz.txt" };

            var result = arr1.Select(x => Path.GetExtension(x).TrimStart('.').ToLower()).GroupBy(y => y, (extension, count) => new
            {
                Extension = extension,
                Count = count.Count()
            });
            foreach (var item in result)
            {
                Console.WriteLine("{0} dosyam  {1} kadar bulunur", item.Extension,item.Count);
            }
            Console.ReadLine();
        }
    }
}
