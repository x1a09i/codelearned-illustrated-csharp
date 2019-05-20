using System;
using System.Threading.Tasks;


namespace AsyncMethodReturnTaskT
{
    class AsyncMethodReturnTaskT
    {
        static void Main(string[] args)
        {
            Task<int> taskSum = DoAsyncStuff.SumAsyn(2, 13);
            // Do Other Things...
            Console.WriteLine("Still Waiting");
            Console.WriteLine("Finished! The value is {0}", taskSum.Result);

            Console.ReadKey();
        }

        static class DoAsyncStuff
        {
            public static async Task<int> SumAsyn(int x, int y)
            {
                // Lambda表达式也可以用作异步处理
                int sum = await Task.Run(() => GetSum(x, y));
                // 返回值类型为Task<T>的T类型
                return sum;
            }

            static int GetSum(int x, int y) { return x + y; }
        }
    }
}
