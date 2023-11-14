using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int AddressID { get; set; }
        public int DepartmentID { get; set; }
    }
    public class Address
    {
        public int ID { get; set; }
        public string AddressLine { get; set; }
    }
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>() 
            {
                new Employee { ID = 1,Name="Preety",AddressID = 1 ,DepartmentID = 1 },
                new Employee { ID = 2,Name="Priyanka",AddressID = 2 ,DepartmentID = 2 },
                new Employee { ID = 3,Name="Anurag",AddressID = 3 ,DepartmentID = 3 },
                new Employee { ID = 4,Name="Pranaya",AddressID = 4 ,DepartmentID = 0 },
                new Employee { ID = 5,Name="Hina",AddressID = 5 ,DepartmentID = 0 },
                new Employee { ID = 6,Name="Sambit",AddressID = 6 ,DepartmentID = 0 },
                new Employee { ID = 7,Name="Happy",AddressID = 7 ,DepartmentID = 0 },
                new Employee { ID = 8,Name="Tarun",AddressID = 8 ,DepartmentID = 0 },
                new Employee { ID = 9,Name="Santosh",AddressID = 9 ,DepartmentID = 1 },
                new Employee { ID = 10,Name="Raja",AddressID = 10 ,DepartmentID = 2 },
                new Employee { ID = 11,Name="Sudhanshu",AddressID = 11 ,DepartmentID = 3 }
               
            };
            List<Address> addresses = new List<Address>() 
            {
                new Address { ID = 1,AddressLine="AddressLine1"},
                new Address { ID = 2,AddressLine="AddressLine2"},
                new Address { ID = 3,AddressLine="AddressLine3"},
                new Address { ID = 4,AddressLine="AddressLine4"},
                new Address { ID = 5,AddressLine="AddressLine5"},
                new Address { ID = 6,AddressLine="AddressLine6"},
                new Address { ID = 7,AddressLine="AddressLine7"},
                new Address { ID = 8,AddressLine="AddressLine8"},
                new Address { ID = 9,AddressLine="AddressLine9"},
                new Address { ID = 10,AddressLine="AddressLine10"},
                new Address { ID = 11,AddressLine="AddressLine11"},
            };
            List<Department> departments = new List<Department>()
            {
                new Department { ID = 1,Name = "IT"},
                new Department { ID = 2,Name = "HR"},
                new Department { ID = 3,Name = "Payroll"},
            };

            var result1 = (from x in employees
                          join y in addresses
                          on x.AddressID equals y.ID
                          join z in departments
                          on x.DepartmentID equals z.ID
                          select new
                          {
                              ID= x.ID,
                              employeeName= x.Name,
                              AddressLine = y.AddressLine,
                              DepartmentName = z.Name
                          });

            foreach (var item in result1)
            {
                Console.WriteLine(item.ID + " " + item.employeeName + " " + item.DepartmentName + " " + item.AddressLine);
            }
            Console.ReadLine();
        }
    }
}
