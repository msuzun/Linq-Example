using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AddressId { get; set; }
    }
    public class Address
    {
        public int Id { get; set; }
        public string AddressLine { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee { Id = 1, Name = "Preety", AddressId = 1 },
                new Employee { Id = 2, Name = "Priyanka", AddressId = 2 },
                new Employee { Id = 3, Name = "Anurag", AddressId = 3 },
                new Employee { Id = 4, Name = "Pranaya", AddressId = 4 },
                new Employee { Id = 5, Name = "Hina", AddressId = 5 },
                new Employee { Id = 6, Name = "Sambit", AddressId = 6 },
                new Employee { Id = 7, Name = "Happy", AddressId = 7 },
                new Employee { Id = 8, Name = "Tarun", AddressId = 8 },
                new Employee { Id = 9, Name = "Santosh", AddressId = 9 },
                new Employee { Id = 10, Name = "Raja", AddressId = 10 },
                new Employee { Id = 11, Name = "Sudhanshu", AddressId = 11 },

            };
            List<Address> addresses = new List<Address>()
            {
                new Address { Id = 1,AddressLine="AddressLine1"},
                new Address { Id = 2,AddressLine="AddressLine2"},
                new Address { Id = 3,AddressLine="AddressLine3"},
                new Address { Id = 4,AddressLine="AddressLine4"},
                new Address { Id = 5,AddressLine="AddressLine5"},
                new Address { Id = 6,AddressLine="AddressLine6"},
                new Address { Id = 7,AddressLine="AddressLine7"},
                new Address { Id = 8,AddressLine="AddressLine8"},
                new Address { Id = 9,AddressLine="AddressLine9"},
                new Address { Id = 10,AddressLine="AddressLine10"},
                new Address { Id = 11,AddressLine="AddressLine11"},
            };
            var result1 = employees.Join(addresses, employee => employee.AddressId, addresse => addresse.Id, (employee, addresse) => new
            {
                EmployeeName = employee.Name,
                AddressLine = addresse.AddressLine
            }).ToList();
            foreach (var item in result1)
            {
                Console.WriteLine("Name : " + item.EmployeeName + " Address: " + item.AddressLine);
            }
            Console.ReadLine();
        }
    }
}
