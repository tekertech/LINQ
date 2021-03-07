using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{

    abstract class Course 
    {
        public int ID { get; set; }
        public string Subject { get; set; }
        public int Rank { get; set; }
    }


    class FreeCourse : Course
    {
    
    }


    class PaidCourse : Course 
    {
        public decimal Fees { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Course> courses = new List<Course>();
            courses.Add(new FreeCourse { ID = 1, Subject = "A", Rank = 10 });
            courses.Add(new PaidCourse { ID = 2, Subject = "B", Rank = 11 });
            courses.Add(new FreeCourse { ID = 3, Subject = "C", Rank = 12 });
            courses.Add(new FreeCourse { ID = 4, Subject = "D", Rank = 13 });


            var paidCourse = from course in courses.OfType<PaidCourse>() select course;

            var freeCourse = from course in courses.OfType<FreeCourse>() select course;


            foreach (var item in freeCourse)
            {
                Console.WriteLine(" Free Courses : " + item.Subject);
            }

            foreach (var item in paidCourse)
            {
                Console.WriteLine("Paid Courses : " + item.Subject);
            }


            Console.ReadLine();
        }
    }
}
