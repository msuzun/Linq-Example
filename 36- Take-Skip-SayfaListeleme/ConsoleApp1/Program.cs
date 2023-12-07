using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }
            public static List<Employee> GetAllEmployees()
            {
                return new List<Employee>()
                {
                    new Employee() {Id = 1, Name ="Pranaya",Department = "IT"},
                    new Employee() {Id = 2, Name ="Priyanka",Department = "IT"},
                    new Employee() {Id = 3, Name ="Preety",Department = "IT"},
                    new Employee() {Id = 4, Name ="Sambit",Department = "IT"},
                    new Employee() {Id = 5, Name ="Sudhanshu",Department = "HR"},
                    new Employee() {Id = 6, Name ="santosh",Department = "HR"},
                    new Employee() {Id = 7, Name ="Happy",Department = "HR"},
                    new Employee() {Id = 8, Name ="Raja",Department = "IT"},
                    new Employee() {Id = 9, Name ="Tarun",Department = "IT"},
                    new Employee() {Id = 10, Name ="Bablu",Department = "IT"},
                    new Employee() {Id = 11, Name ="Hina",Department = "HR"},
                    new Employee() {Id = 12, Name ="Anurag",Department = "HR"},
                    new Employee() {Id = 13, Name ="Dillip",Department = "HR"},
                    new Employee() {Id = 14, Name ="Manoj",Department = "HR"},
                    new Employee() {Id = 15, Name ="Lima",Department = "IT"},
                    new Employee() {Id = 16, Name ="Sona",Department = "IT"}
                };
            }
        }
        static void Main(string[] args)
        {
            int RecordPerPage = 4;
            int PageNumber = 0;
            do
            {
                Console.WriteLine("1 ile 4 asarında bir sayfa numarası giriniz");
                if (int.TryParse(Console.ReadLine(),out PageNumber))
                {
                    if (PageNumber > 0 && PageNumber <5)
                    {
                        var result = Employee.GetAllEmployees().Skip((PageNumber - 1) * RecordPerPage).Take(RecordPerPage).ToList();
                        Console.WriteLine("Sayfa numaramız : " + PageNumber);
                        foreach (var employee in result)
                        {
                            Console.WriteLine($"Name : {employee.Name}, Department: {employee.Department}");
                          
                        }
                    }
                    else
                    {
                        Console.WriteLine("Lutfen geçerli bir numara giriniz");
                    }
                }
                else
                {
                    Console.WriteLine("Lutfen geçerli bir numara giriniz");
                }
                Console.ReadLine();
            } while (true);
        }
    }
}
