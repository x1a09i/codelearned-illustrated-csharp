using System;
using System.Linq;

namespace MethodSyntaxQuerySyntax
{
    class MethodSyntaxQuerySyntax
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 5, 28, 31, 17, 16, 42 };
            // 查询式语法
            var numsQuery = from n in numbers
                            where n < 20
                            select n;
            // 方法式语法（使用Lambda表达式）
            var numsMethod = numbers.Where(x => x < 20);
            // 结合使用
            var numsCount = (from n in numbers
                             where n < 20
                             select n).Count();

            Console.Write("Query Syntax:");
            // 从这一句（首次访问查询变量时）开始，查询语句才开始被执行
            foreach (var item in numsQuery)
                Console.Write("{0}, ", item);

            Console.WriteLine();

            Console.Write("Method Syntax:");
            foreach (var item in numsMethod)
                Console.Write("{0}, ", item);

            Console.WriteLine();
            Console.WriteLine("Count:{0}", numsCount);

            Console.ReadKey();
        }
    }
}
