using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{

    class Program
    {
        static void Main(string[] args)
        {
            // DefaultIfEmpty
            // List<int> numbers = new List<int>() { 10, 20, 30 };  ok
            List<int> numbers = new List<int>() { };
            var newNumbers = numbers.DefaultIfEmpty(-9); // Default Sıfır (0)
            foreach (var item in newNumbers)
            {
                Console.WriteLine("My List : " + item);
            }


            // SequenceEqual

            List<string> listOne = new List<string>() { "A", "B", "c" };
            List<string> listTwo = new List<string>() { "A", "B", "C" };
            List<string> listThree = new List<string>() { "A", "C", "B" };

            
            var result = listOne.SequenceEqual(listTwo,StringComparer.OrdinalIgnoreCase); // true
                result = listOne.SequenceEqual(listThree,StringComparer.OrdinalIgnoreCase); // false
                result = listOne.OrderBy(x => x).SequenceEqual(listThree.OrderBy(y => y), StringComparer.OrdinalIgnoreCase); //  true



            Console.WriteLine("Result : " + result);

            Console.ReadLine();
        }

    }
}
