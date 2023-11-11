using System;
using System.Collections;
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
            QuerySyntax();
            Console.ReadLine();
        }
        static void QuerySyntax()
        {
            List<int> integerList = new List<int>()
            {
                1,
                2,
                3,
                4,
                5,
                6,
                7,
                8,
                9,
                10
            };

            //var QuerySyntax = from obj in integerList
            //                  where obj > 5
            //                  select obj;
            //IEnumerable<int> QuerySyntax = from obj in integerList
            //                  where obj > 5
            //                  select obj;
            IQueryable<int> QuerySyntax = from obj in integerList.AsQueryable()
                                           where obj > 5
                                           select obj;
            foreach (var obj in QuerySyntax)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
