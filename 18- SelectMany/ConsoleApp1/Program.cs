using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Department
    {
        public string Name { get; set; }
    }
    public class Employee
    {
        public int ID { get; set; }
        public List<Department> departments { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(
                new Employee { ID = 1, departments = new List<Department>() { 
                    new Department {Name ="Marketing"},
                    new Department { Name = "Sales"} 
                } 
                });
            employees.Add(
                new Employee { ID = 2, departments = new List<Department>() { 
                    new Department {Name ="Advertisement"},
                    new Department { Name = "Production"} 
                } 
                });            
            employees.Add(
                new Employee { ID = 3, departments = new List<Department>() { 
                    new Department {Name ="Production"},
                    new Department { Name = "Sales"} 
                } 
                });
            var result = employees.SelectMany(x => x.departments);
            foreach (var item in result)
            {
                Console.WriteLine(item.Name);
            }
            Console.ReadLine();
        }
    }
}
