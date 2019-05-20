using System;
using System.Linq;

namespace FromClauseInBody
{
    class FromClauseInBody
    {
        static void Main(string[] args)
        {
            var groupA = new[] { 2, 4, 6, 7, 8, 12, 13 };
            var groupB = new[] { 6, 7, 8, 9 };

            var someInts = from a in groupA
                           from b in groupB
                           where a > 4 && b < 9
                           select new { a, b, sum = a + b }; // 此处用到了匿名类型

            foreach (var a in someInts)
                Console.WriteLine(a);

            Console.ReadKey();
        }
    }
}
