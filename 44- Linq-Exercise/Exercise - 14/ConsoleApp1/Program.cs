using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Puan { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> tempList = new List<Student>();
            int n;
            tempList.Add(new Student { Id = 1, Name = "Joseph",Puan = 800});
            tempList.Add(new Student { Id = 2, Name = "Alex",Puan = 458});
            tempList.Add(new Student { Id = 3, Name = "Harris",Puan = 900});
            tempList.Add(new Student { Id = 4, Name = "Taylor",Puan = 900});
            tempList.Add(new Student { Id = 5, Name = "Smith",Puan = 458});
            tempList.Add(new Student { Id = 6, Name = "Natasa",Puan = 700});
            tempList.Add(new Student { Id = 7, Name = "David",Puan = 750});
            tempList.Add(new Student { Id = 8, Name = "Harry",Puan = 700});
            tempList.Add(new Student { Id = 9, Name = "Nicolash",Puan = 597});
            tempList.Add(new Student { Id = 10, Name = "Jenny",Puan = 750});

            Console.WriteLine("Kaçıncı sıradaki öğrenciyi istiyorsunuz");

            n= Convert.ToInt32(Console.ReadLine());
            var result = (from s in tempList
                         group s by s.Puan into deger
                         orderby deger.Key descending
                         select new
                         {
                             Record = deger.ToList()
                         }).ToList();
            result[n-1].Record.ForEach(x => Console.WriteLine("Id: {0},Name: {1},Puan: {2}",x.Id,x.Name,x.Puan));
            Console.ReadLine();
        }
    }
}
