using System;
using System.Linq;

namespace IntoClause
{
    class IntoClause
    {
        static void Main(string[] args)
        {
            var groupA = new[] { 1, 2, 3, 4 };
            var groupB = new[] { 3, 4, 6, 7 };
            var groupC = new[] { 9, 19, 29, 39 };

            var query = from a in groupA
                        join b in groupB on a equals b
                        into groupAB join c in groupC on a * 3 equals c
                        from abc in groupAB
                        select abc;

            foreach (var number in query)
                Console.WriteLine(number);

            Console.ReadKey();
        }
    }
}
