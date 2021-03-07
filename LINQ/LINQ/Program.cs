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
            List<int> integerList = new List<int>() { 1,2,3,4,5,6,7,8,9};

            // IEnumerable Interface'in altında yer alan GetEnumerator  metotunu kullanarak foreach yapısını çalıştırılır.
            var result = integerList.Where(x => x > 5);

            foreach (var item in result)
            {
                Console.WriteLine("Result :" + item);
            }

            IEnumerable<int> resultIEnumerable = integerList.Where(x => x > 5);

            foreach (var item in resultIEnumerable)
            {
                Console.WriteLine("IEnumerable : " + item);
            }

            IQueryable<int> queryableList = from list in integerList.AsQueryable() where list > 5 select list;

            foreach (var item in queryableList)
            {
                Console.WriteLine("IQueryable : " + item);
            }

            Console.ReadLine();
        }
    }
}
