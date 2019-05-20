using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncMethodReturnVoid
{
    class AsyncMethodReturnVoid
    {
        static void Main(string[] args)
        {
            DoAsyncStuff.SumSync(2, 13);
            Thread.Sleep(2000);
            Console.WriteLine("Programe Existing...");
        }
    }

    class DoAsyncStuff
    {
        public static async void SumSync(int x, int y)
        {
            int value = await Task.Run(() => GetSum(x, y));
            Console.WriteLine("Value: {0}", value);
        }

        static int GetSum(int x, int y) { return x + y; }
    }
}
