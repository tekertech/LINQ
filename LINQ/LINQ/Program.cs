using System;
using System.Collections.Generic;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> countries = new List<string>();
            countries.Add("India");
            countries.Add("USA");
            countries.Add("UK");

            
            foreach (var item in countries)
            {
                Console.WriteLine("Ülke : " + item);
            }

            Console.ReadLine();
        }
    }
}
