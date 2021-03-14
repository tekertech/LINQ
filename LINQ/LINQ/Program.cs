using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{


    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Branch { get; set; }
        public int Age { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {

                new Student(){ID=1,Name="B",Branch = "10",Gender = "K",Age = 21},
                new Student(){ID=1,Name="C",Branch = "20",Gender = "K",Age = 25},
                new Student(){ID=1,Name="B",Branch = "10",Gender = "K",Age = 22},
                new Student(){ID=1,Name="B",Branch = "10",Gender = "E",Age = 20},
                new Student(){ID=1,Name="A",Branch = "10",Gender = "K",Age = 20},
                new Student(){ID=1,Name="B",Branch = "20",Gender = "E",Age = 24},
                new Student(){ID=1,Name="C",Branch = "20",Gender = "E",Age = 24},
                new Student(){ID=1,Name="B",Branch = "20",Gender = "E",Age = 24},
                new Student(){ID=1,Name="C",Branch = "20",Gender = "K",Age = 26}
            };


            //var result = from student in students group student by student.Name;

            // var result = students.GroupBy(x => x.Name);
            // foreach (var item in result)
            // {
            //     Console.WriteLine(" " + item.Key + " " + item.Count());
            // 
            //     foreach (var student in item)
            //     {
            //         Console.WriteLine("Branch : " + student.Name + " Gender : " + student.Gender);
            //     }
            // }
            // 

            // Group By Multiple

            //var result = students.GroupBy(x => new { x.Branch, x.Gender }).OrderByDescending(g => g.Key.Branch).ThenBy(g => g.Key.Gender).Select(g =>
            //{
            //    Branch = g.Key.Branch,
            //    Gender = g.Key.Gender,
            //    Students = g.OrderBy(x=> x.Name)
            //});



            var res =    from student in students group student by new { student.Branch, student.Gender } into result
                         orderby result.Key.Branch descending 
                         select new
                         {
                             Branch = result.Key.Branch,
                             Gender = result.Key.Gender,
                             Studensts = result.OrderBy(x => x.Name)
                         };

            foreach (var group in res)
            {
                Console.WriteLine("Branch : " + group.Branch + " Gender : " + group.Gender + " CCount : " + group.Studensts.Count());
                foreach (var item in group.Studensts)
                {
                    Console.WriteLine("Name :  " + item.Name + " Branch :" + item.Branch + " Gender :" + item.Gender);
                }
            }



            Console.ReadLine();
        }
    }
}
