using System;
using System.Threading.Tasks;

namespace AsyncMethodReturnTask
{
    class AsyncMethodReturnTask
    {
        static void Main(string[] args)
        {
            Task task = DoAsyncStuff.SumSync(2, 13);
            Console.WriteLine(task.Status.ToString());

            Console.ReadKey();
        }
    }

    static class DoAsyncStuff
    {
        public static async Task SumSync(int x, int y)
        {
            int value = await Task.Run(() => GetSum(x, y));
            Console.WriteLine("Value: {0}", value);
        }

        static int GetSum(int x, int y) { return x + y; }
    }
}
