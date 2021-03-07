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

        public int Age { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student() { ID = 1, Name = "Ali",    Rank = 1 , Age = 11});
            students.Add(new Student() { ID = 2, Name = "Ayşe",   Rank = 1 , Age = 12});
            students.Add(new Student() { ID = 3, Name = "Furkan", Rank = 2 , Age = 10});
            students.Add(new Student() { ID = 4, Name = "Ferhat", Rank = 2 , Age = 5});

            // Query Syntax
            var resultQuery = from student in students orderby student.Rank, student.Age select student;

            foreach (var item in resultQuery)
            {
                Console.WriteLine("Query : " + item.Name);
            }


            // Method Syntax
            var resultMethod = students.Where(x => x.ID > 2 && x.Name.Contains("F")).OrderByDescending(x => x.Age).ThenByDescending(x => x.ID);



            foreach (var item in resultMethod)
            {
                Console.WriteLine("Method : " + item.Name);
            }

            Console.ReadLine();
        }
    }
}
