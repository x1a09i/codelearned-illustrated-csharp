using System;
using System.Linq;

namespace LetClause
{
    class LetClause
    {
        static void Main(string[] args)
        {
            var groupA = new[] { 0, 1, 3, 4, 5, 6, 7 };
            var groupB = new[] { 8, 9, 10, 11, 12 };

            var result = from a in groupA
                         from b in groupB
                         // let子句带来一个新变量
                         let sum = a + b
                         where sum == 12
                         select new { a, b, sum };

            foreach (var obj in result)
                Console.WriteLine(obj);

            Console.ReadKey();
        }
    }
}
