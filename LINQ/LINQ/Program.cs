using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{

     /// <summary>
     /// Aggregate Methods (Sum,Max,Min,Avg...)
     /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[] { 12, 15, 13, 2, 87 };

            // Method Syntax
            int sum = sayilar.Sum();
            // Query Syntax
            int total = (from sayi in sayilar select sayi).Sum();

            int maxValue = sayilar.Max();
            int maxValue1 = (from sayi in sayilar select sayi).Max();

            int minValue = sayilar.Min();
            int minValue1 = (from sayi in sayilar select sayi).Min();

            double avgValue = sayilar.Average();
            double avgValue1 = (from sayi in sayilar select sayi).Average();

            int countValue = sayilar.Count();
            int countValue1 = (from sayi in sayilar select sayi).Count();



            Console.ReadLine();
        }
    }
}
