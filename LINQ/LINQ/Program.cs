using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namesDoctor = { "Ahmet", "Ali", "Ayşe", "Fatma" };
            string[] namesEngineer = { "Ahmet", "Ali", "Furkan", "Cevdet" };

            // AUB  Union
            var result = namesDoctor.Union(namesEngineer);

            foreach (var item in result)
            {
                Console.WriteLine(" Ortak Alanlar : " + item);
            }

            // Concat   (Union all gibi çalışır)
            var resultConcat = namesDoctor.Concat(namesEngineer);

            foreach (var item in resultConcat)
            {
                Console.Write(" " + item + "-");
            }

            // Intersec   (Kesisim)

            var resultIntersec = namesDoctor.Intersect(namesEngineer);
            Console.WriteLine();
            Console.WriteLine("Kesişim : Intersec");
            foreach (var item in resultIntersec)
            {
                Console.Write(" " +item +"-");
            }


            Console.WriteLine("*******************************************************************");
            Console.WriteLine("Distinct");
            // Distinct

            int[] sayilar = new int[] { 1, 2, 3, 4, 5, 5, 6, 6, 6, 6, 8 };
            var sayilarDistinct = sayilar.Distinct();
            foreach (var item in sayilarDistinct)
            {
                Console.Write(" " + item + "-");
            }

            Console.ReadLine();
        }
    }
}
