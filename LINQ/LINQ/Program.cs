using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{

    /// <summary>
    /// from <optional data type> <range variable> in <IEnumerable <T>>   <Query Operator> lambda expression <select> <range variable | fields of range variable>
    /// </summary>
    class Insan 
    {
        public string Name { get; set; }
        public int Yas { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Insan> insans = new List<Insan>();
            insans.Add(new Insan() { Name = "Ali", Yas = 20 });
            insans.Add(new Insan() { Name = "Veli", Yas = 12 });
            insans.Add(new Insan() { Name = "Ayşe", Yas = 35 });
            insans.Add(new Insan() { Name = "Furkan", Yas = 43 });
            insans.Add(new Insan() { Name = "Veysel", Yas = 28 });

            // Query Syntax : from Clause
            var results = from insan in insans
                                  where
                                  insan.Name.Contains("A")
                                  select insan;


            // Method Syntax
            var resultMethod = insans.Where(x => x.Name.Contains("A")).Select(c => c.Name).ToList();


            foreach (var item in results)
            {
                Console.WriteLine("Insan : " + item.Name);
            }

            foreach (var item in resultMethod)
            {
                Console.WriteLine("Insan : " + item);
            }



            Console.ReadLine();
        }
    }
}
