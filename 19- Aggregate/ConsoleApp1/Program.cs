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
            int[] intArray = new int[] { 10,30,50,40,60,20,70,100};
            int totalSum1 = intArray.Sum(); //MethodSyntax
            int totalSum2 = (from c in intArray select c).Sum(); // QuerySyntax

            Console.WriteLine("Toplam değer(MethodSyntax) = " +totalSum1);
            Console.WriteLine("Toplam değer(QuerySyntax) = " + totalSum2);

            int Max1 = intArray.Max(); //MethodSyntax
            int Max2 = (from c in intArray select c).Max(); // QuerySyntax

            Console.WriteLine("Max değer(MethodSyntax) = " + Max1);
            Console.WriteLine("Max değer(QuerySyntax) = " + Max2);

            int Min1 = intArray.Min(); //MethodSyntax
            int Min2 = (from c in intArray select c).Min(); // QuerySyntax

            Console.WriteLine("Min değer(MethodSyntax) = " + Min1);
            Console.WriteLine("Min değer(QuerySyntax) = " + Min2);

            double Average1 = intArray.Average(); //MethodSyntax
            double Average2 = (from c in intArray select c).Average(); // QuerySyntax

            Console.WriteLine("Ortalama değer(MethodSyntax) = " + Average1);
            Console.WriteLine("Ortalama değer(QuerySyntax) = " + Average2);

            int Count1 = intArray.Count(); //MethodSyntax
            int Count2 = (from c in intArray select c).Count(); // QuerySyntax

            Console.WriteLine("Min değer(MethodSyntax) = " + Count1);
            Console.WriteLine("Min değer(QuerySyntax) = " + Count2);

            string[] skills = { "C#", "MVC", "WCF", "SQL", "LINQ" };
            var Aggreate1 = skills.Aggregate((x, y) => x + ", " + y);
            Console.WriteLine("Metnin tamamı : " + Aggreate1);
            Console.ReadLine();
        }
    }
}
