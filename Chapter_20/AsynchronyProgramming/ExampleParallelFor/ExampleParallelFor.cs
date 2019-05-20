using System;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ExampleParallelFor
{
    class ExampleParallelFor
    {
        static void Main(string[] args)
        {
            /* 简单的TPL（Task Parallel Library）示例。
                注意，迭代将会执行14次，而不是15次
                且因为处理是并行处理的，所以结果为乱序 */
            Parallel.For(0, 100, i =>
                Console.WriteLine("The square of {0} is {1}", i, Math.Pow(i, 2)));

            // 使用并行处理来填充数组
            const int maxValues = 50;
            int[] squares = new int[maxValues];

            Parallel.For(0, maxValues, i => squares[i] = i * i);

            // 注意，虽然填充操作是以并行方式处理的，但最终结果将是有序数组！
            foreach (int i in squares)
                Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}
