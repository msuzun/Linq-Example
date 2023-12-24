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
            short iteratorNumber;
            List<int> tempList = new List<int>();
            int tempS;
            Console.WriteLine("Eleman Giriniz");
            iteratorNumber = Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i < iteratorNumber; i++)
            {
                Console.WriteLine("Member {0}", i+1);
                tempList.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("Listelemek için hangi değerden başlasın");
            tempS = Convert.ToInt32(Console.ReadLine());
            var result = tempList.FindAll(x => x > tempS);

            Console.WriteLine("-----------------------");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
