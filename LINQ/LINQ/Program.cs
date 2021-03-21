using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
     
    public class Employee 
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int AddressId { get; set; }
        public int DepartmentId { get; set; }
    }

    public class Address 
    {
        public int ID { get; set; }
        public string AdsressLine { get; set; }

    }

    public class Department 
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){ID =1  ,DepartmentId = 10 ,Name="Preety",AddressId = 1},
                new Employee(){ID =2  ,DepartmentId = 20 ,Name="Privanka",AddressId = 2},
                new Employee(){ID =3  ,DepartmentId = 20 ,Name="Anurag",AddressId = 3},
                new Employee(){ID =4  ,DepartmentId = 0 ,Name="Pranaya",AddressId = 4},
                new Employee(){ID =5  ,DepartmentId = 0 ,Name="Hina",AddressId = 5},
                new Employee(){ID =6  ,DepartmentId = 0 ,Name="Sambit",AddressId = 6},
                new Employee(){ID =7  ,DepartmentId = 0 ,Name="Happy",AddressId = 7},
                new Employee(){ID =8  ,DepartmentId = 0 ,Name="Tarun",AddressId = 8},
                new Employee(){ID =9  ,DepartmentId = 10 ,Name="Santos",AddressId = 9},
                new Employee(){ID =10 ,DepartmentId = 20 ,Name="Raja",AddressId = 10},
                new Employee(){ID =11 ,DepartmentId = 30 ,Name="Sudhanshu",AddressId = 11}
            };

            List<Address> addresses = new List<Address>() {
             new Address(){ID = 1, AdsressLine = "AdsressLine1"},
             new Address(){ID = 2, AdsressLine = "AdsressLine2"},
             new Address(){ID = 3, AdsressLine = "AdsressLine3"},
             new Address(){ID = 4, AdsressLine = "AdsressLine4"},
             new Address(){ID = 5, AdsressLine = "AdsressLine5"},
             new Address(){ID = 9, AdsressLine = "AdsressLine9"},
             new Address(){ID = 10, AdsressLine = "AdsressLine10"},
             new Address(){ID = 11, AdsressLine = "AdsressLine11"}
            };


            List<Department> departments = new List<Department>() {
              new Department(){ ID = 10, Name = "IT"},
              new Department(){ ID = 20, Name = "HR"},
              new Department(){ ID = 30, Name = "Payroll"}
            };



            // Query Syntax
            var result = from employee in employees
                         join adrees in addresses on employee.AddressId equals adrees.ID
                         select new
                         {
                             EmployeeName = employee.Name,
                             AddressLine = adrees.AdsressLine
                         };

            foreach (var item in result.ToList())
            {
                Console.WriteLine("EmployeeName : " + item.EmployeeName + " AddreesLine :" + item.AddressLine);
            }

            //Method Syntax :
            result = employees.Join(addresses, x => x.AddressId, y => y.ID, (x, y) => new
            {
                EmployeeName = x.Name,
                AddressLine = y.AdsressLine
            }).ToList();


            // Multiple Data Source
            var multipleDataSource = from employee in employees
                                     join adress in addresses on employee.AddressId equals adress.ID
                                     join department in departments on employee.DepartmentId equals department.ID
                                     select new
                                     {
                                         EmployeeName = employee.Name,
                                         AddressLine = adress.AdsressLine,
                                         DepartmentName = department.Name
                                     };

            foreach (var item in multipleDataSource)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }

    }
}
