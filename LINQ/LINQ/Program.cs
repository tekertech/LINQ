using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            foreach (var item in intArray)
            {
                Console.Write(" " + item + " , ");
            }

            Console.WriteLine();
            var reverseArray = intArray.Reverse();

            foreach (var item in reverseArray)
            {
                Console.Write(" " + item + " , ");
            }


            string[] namesDoctor = { "Ahmet", "Ali", "Ayşe", "Fatma" };
            string[] namesEngineer = { "Ahmet", "Ali", "Furkan", "Cevdet" };

            var doctorFarkEngineer = namesDoctor.Except(namesEngineer);

            foreach (var item in doctorFarkEngineer)
            {
                Console.WriteLine(item);
            }

            var engineerDiffDoctor = namesEngineer.Except(namesDoctor);

            foreach (var item in engineerDiffDoctor)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
