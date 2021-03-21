using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{


    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }

        public static List<Employee> GetEmployees()
        {
            return new List<Employee>() {
                                        new Employee(){ID = 1, Name = "A", Department = "IT"},
                                        new Employee(){ID = 2, Name = "B", Department = "IT"},
                                        new Employee(){ID = 3, Name = "C", Department = "IT"},
                                        new Employee(){ID = 4, Name = "D", Department = "HR"},
                                        new Employee(){ID = 5, Name = "E", Department = "HR"},
                                        new Employee(){ID = 6, Name = "F", Department = "HR"},
                                        new Employee(){ID = 7, Name = "F", Department = "HR"},
                                        new Employee(){ID = 8, Name = "H", Department = "HR"},
                                        new Employee(){ID = 9, Name = "J", Department = "IT"},
                                        new Employee(){ID = 10, Name = "K", Department = "IT"},
                                        new Employee(){ID = 11, Name = "L", Department = "IT"},
                                        new Employee(){ID = 12, Name = "V", Department = "IT"},

                                       };
        }
    }





    class Program
    {
        
        static void Main(string[] args)
        {
            //Take , TakeWhile && Where
            List<int> numbers = new List<int>() { 8, 1, 2, 3, 8, 9, 4, 5, 6, 7 };
            var number = numbers.Take(4);
            number = (from num in numbers select num).Take(4);
            number = numbers.Take(4).Where(x => x > 3);
            number = numbers.TakeWhile(x => x < 3);
            //number = numbers.Where(x => x < 3);

            // Skip, SkipWhile

            number = numbers.Skip(2);
            number = numbers.OrderBy(num => num).Where(x => x > 3).Skip(4);
            number = numbers.Skip(4).Where(num => num < 6);

            number = numbers.SkipWhile(x => x < 5);

            foreach (var item in number)
            {
                Console.WriteLine(item);
            }

            int RecordsPerPage = 4;
            int PageNumber = 0;
            bool flag = true;
            
            do
            {
                
                Console.WriteLine("1 ile 4 arasında bir sayfa numarası giriniz");

                if (int.TryParse(Console.ReadLine(), out PageNumber))
                {

                    var result = Employee.GetEmployees().Skip((PageNumber - 1) * RecordsPerPage).Take(RecordsPerPage).ToList();

                    foreach (var item in result)
                    {
                        Console.WriteLine(item.ID + " " + item.Name + " " + item.Department);
                    }
                }
                else {
                    flag = false;
                }

            } while (flag);

            Console.ReadLine();
        }
    }
}
