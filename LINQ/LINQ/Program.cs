using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{

    class Employee 
    {
        public int ID { get; set; }
        public List<Department> Departments { get; set; }
    }

    class Department 
    {
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee()
            {
                ID = 1,
                Departments = new List<Department>()
               {
                  new Department(){ Name = "Marketing"},
                  new Department(){ Name = "Sales"}
               }
            });

            employees.Add(new Employee()
            {
                ID = 2,
                Departments =  new List<Department>()
                {
                    new Department(){Name="Advertisement"},
                    new Department(){Name="Production"}
                }
            });

            employees.Add(new Employee()
            {
                ID = 3,
                Departments = new List<Department>()
                {
                    new Department(){Name="Production"},
                    new Department(){Name="Sales"}
                }
            });


            var resultDeparments = employees.SelectMany(x => x.Departments);

            foreach (var item in resultDeparments)
            {
                Console.WriteLine(" " + item.Name);
            }


            Console.ReadLine();
        }
    }
}
