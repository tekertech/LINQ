using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Student 
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Rank { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student() { ID = 1, Name = "Ali", Rank = 10});
            students.Add(new Student() { ID = 2, Name = "Ayşe", Rank = 11 });
            students.Add(new Student() { ID = 3, Name = "Furkan", Rank = 12 });
            students.Add(new Student() { ID = 4, Name = "Ferhat", Rank = 13 });

            // Query Syntax
            var resultStudent = from student in students where student.Name.Contains("F") orderby student.Rank descending select student;

            foreach (var item in resultStudent)
            {
                Console.WriteLine(" Name : " + item.Name);
            }

            // Method Syntax


            var result = students.OrderBy(x => x.Rank);

            foreach (var item in result)
            {
                Console.WriteLine("Order By ASC:" + item.Name);
            }

            var resultDESC = students.OrderByDescending(x => x.Rank);

            foreach (var item in resultDESC)
            {
                Console.WriteLine("Order By Desc : " + item.Name);
            }


            Console.ReadLine();
        }
    }
}
