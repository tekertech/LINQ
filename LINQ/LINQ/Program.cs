using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Person 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Branch { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        /*
           Average with Selector, Average with Query Syntax, Average with Group By
         
         */
        static void Main(string[] args)
        {
            List<Person> peoples = new List<Person> {
              new Person { Id = 1001, Name = "Preety",  Gender = "Female", Branch = "CSE", Age = 20},
              new Person { Id = 1002, Name = "Snurag",  Gender = "Male",   Branch = "ETC", Age = 21},
              new Person { Id = 1003, Name = "Pranaya", Gender = "Male",   Branch = "CSE", Age = 21},
              new Person { Id = 1004, Name = "Anurag",  Gender = "Male",   Branch = "CSE", Age = 20},
              new Person { Id = 1005, Name = "Hina",    Gender = "Female", Branch = "ETC", Age = 20},
              new Person { Id = 1006, Name = "Priyanka",Gender = "Female", Branch = "CSE", Age = 21},
              new Person { Id = 1007, Name = "Santosh", Gender = "Male",   Branch = "CSE", Age = 22},
              new Person { Id = 1008, Name = "Tina",    Gender = "Female", Branch = "CSE", Age = 21},
              new Person { Id = 1009, Name = "Celina",  Gender = "Female", Branch = "ETC", Age = 22},
              new Person { Id = 1010, Name = "Sambit",  Gender = "Male",   Branch = "ETC", Age = 21}
             };



            var querySyntaxMultiableGroupBy = from people in peoples
                                              group people by new { people.Branch, people.Gender } into result
                                              orderby result.Key.Branch , result.Key.Gender 
                                              select new
                                              {
                                                  Branch = result.Key.Branch,
                                                  Gender = result.Key.Gender,
                                                  AverageAge = result.Average(x => x.Age),
                                                  Peoples =  result
                                              };


            foreach (var item in querySyntaxMultiableGroupBy)
            {
                Console.WriteLine("***********************************querySyntaxMultiableGroupBy*****************************************************");
                Console.WriteLine("***************Branch : " + item.Branch + " Gender :" +item.Gender + " Average :" + item.AverageAge + "************");
                Console.WriteLine("******************************************************************************************************************");
                foreach (var per in item.Peoples)
                {
                    Console.WriteLine("Name : " + per.Name + " Gender :" + per.Gender + " Branch :" + per.Gender + " Age :" + per.Age);
                }
            }


            var methodSyntaxMultiableGroupBy = peoples.GroupBy(x => new { x.Branch, x.Gender }).OrderByDescending(y => y.Key.Branch).ThenBy(y => y.Key.Gender).Select(y => new { 
              Branch = y.Key.Branch,
              Gender = y.Key.Gender,
              AverageAge = y.Average(x=>x.Age),
              Peoples = y
            });

            foreach (var item in methodSyntaxMultiableGroupBy)
            {
                Console.WriteLine("*************************methodSyntaxMultiableGroupBy*************************************************************");
                Console.WriteLine("***************Branch : " + item.Branch + " Gender :" + item.Gender + " Average :" + item.AverageAge + "**********");
                Console.WriteLine("******************************************************************************************************************");
                foreach (var per in item.Peoples)
                {
                    Console.WriteLine("Name : " + per.Name + " Gender :" + per.Gender + " Branch :" + per.Gender + " Age :" + per.Age);
                }
            }




            Console.ReadLine();
        }
    }
}
