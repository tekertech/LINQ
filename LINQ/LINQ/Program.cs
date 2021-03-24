using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{

    class Program
    {
        static void Main(string[] args)
        {
            //   Cast
            ArrayList arrayList = new ArrayList { 10, 20, 30 };

            IEnumerable<int> result = arrayList.Cast<int>(); // true
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            arrayList.Add("Mehmet");
            // result = arrayList.Cast<int>();
            // foreach (var item in result)   // Unable to cast object of type 'System.String' to type 'System.Int32'.'
            // {
            //     Console.WriteLine(item);
            // }

            // Cast and OffType Diff


            result = arrayList.OfType<int>();

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
