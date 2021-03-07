using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{

    class Student 
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public bool IsFeesSubmitted { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student() { ID = 1, Name = "Mehmet", IsFeesSubmitted = true });
            students.Add(new Student() { ID = 2, Name = "Ali", IsFeesSubmitted = true });
            students.Add(new Student() { ID = 3, Name = "Burak", IsFeesSubmitted = true });
            students.Add(new Student() { ID = 4, Name = "Enes", IsFeesSubmitted = true });
            students.Add(new Student() { ID = 5, Name = "Fatma", IsFeesSubmitted = false });
            students.Add(new Student() { ID = 6, Name = "Musa", IsFeesSubmitted = true });

            var flag = students.All(x => x.IsFeesSubmitted == true);
            Console.WriteLine("Tüm öğrencilerin masreafı ödendi mi ? : " + flag);

            var isFeesSubmittedFlag = students.Any(x => x.IsFeesSubmitted == false);
            Console.WriteLine("Masrafı ödenmmeiş varmı : " + isFeesSubmittedFlag);

            Student result = students.Where(x => x.Name.Contains("Mehmet")).FirstOrDefault();

            Console.WriteLine("Mehmet : " + result.IsFeesSubmitted);


            Console.ReadLine();
        }
    }
}
