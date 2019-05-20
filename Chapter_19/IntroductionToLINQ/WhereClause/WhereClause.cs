using System;
using System.Linq;

namespace WhereClause
{
    class WhereClause
    {
        static void Main(string[] args)
        {
            var groupA = new[] { 3, 4, 5, 6 };
            var groupB = new[] { 6, 7, 8, 9 };

            var someInts = from a in groupA
                           from b in groupB
                           let sum = a + b
                           // 两个where子句中的条件互为AND关系
                           where sum >= 11
                           where a > 4
                           select new { a, b, sum };

            foreach (var data in someInts)
                Console.WriteLine(data);

            Console.ReadKey();
        }
    }
}
