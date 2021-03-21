using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{

    class Program
    {
        static void Main(string[] args)
        {
            // Range
            List<int> numbers = Enumerable.Range(1, 10).ToList();
            numbers = Enumerable.Range(1, 10).Where(x => x % 2 == 0).ToList();
            numbers = Enumerable.Range(5, 7).Select(x => x * x).ToList();
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            // Repeat

            IEnumerable<string> names = Enumerable.Repeat("Mehmet", 5);

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            //Zip

            int[] numberSequence = { 10, 20, 30, 40 };
            string[] nameSequence = { "A", "B", "C", "D", "E", "F", };

            var result = numberSequence.Zip(nameSequence, (x, y) => x + " - " + y);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
