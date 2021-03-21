using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
     
    public class Employee 
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int AddressId { get; set; }
        public int DepartmentId { get; set; }
    }

    public class Address 
    {
        public int ID { get; set; }
        public string AdsressLine { get; set; }

    }

    public class Department 
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1,2,3,4,5,6,7,8,9,10 };

            //  ElementAt, ElementAtOrDefault
            // var element = numbers.ElementAt(1);
            //  var element = numbers.ElementAt(12);  // 'Index was out of range. Must be non-negative and less than the size of the collection. (Parameter 'index')'
            var element = numbers.ElementAtOrDefault(12);
            Console.WriteLine("ElementAt : " + element);

            // First, FirstOrDefault
            // var first = numbers.First();  
            //var first = numbers.First(x => x % 3 == 0);
            // var first = numbers.First(x => x > 50); // System.InvalidOperationException   Message = Sequence contains no matching element
            var first = numbers.FirstOrDefault(x => x > 50);
            Console.WriteLine("First :" + first);

            // Last, LastOrDefault
            //var lastNumber = numbers.Last();
            var lastNumber = (from number in numbers select number).Last();
            Console.WriteLine("Last Number :" + lastNumber);


            // Single, SingleOrDefault
            List<int> singleNumber = new List<int>() { 38, 68};
            //var single = singleNumber.Single();
            //var single = singleNumber.Single();  // System.InvalidOperationException: 'Sequence contains more than one element'
            //var single = singleNumber.SingleOrDefault(); // System.InvalidOperationException: 'Sequence contains more than one element'
            var single = singleNumber.SingleOrDefault( x => x > 48); 

            Console.WriteLine("Single Number : " + single);

            Console.ReadLine();
        }

    }
}
