using System;
using System.Threading;
using System.Threading.Tasks;

namespace CancellingAsyncOperation
{
    class CancellingAsyncOperation
    {
        static void Main(string[] args)
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            // 将CancellationTokenSource的Token属性与CancellationToken对象关联
            CancellationToken ct = cts.Token;

            MyClass mc = new MyClass();
            Task t = mc.RunAsync(ct);

            Thread.Sleep(5000);
            cts.Cancel();

            t.Wait();

            Console.WriteLine("Was Cancelled: {0}", ct.IsCancellationRequested);
            Console.ReadKey();
        }
    }

    class MyClass
    {
        public async Task RunAsync(CancellationToken ct)
        {
            if (ct.IsCancellationRequested) return;
            // 注意此处的Run()方法开启了不同的线程
            await Task.Run(() => CycleMethod(ct), ct);
        }

        void CycleMethod(CancellationToken ct)
        {
            Console.WriteLine("Starting CycleMethod");
            const int maxCycle = 9;

            for (int i = 0; i < maxCycle; i++)
            {
                if (ct.IsCancellationRequested) return;
                Thread.Sleep(1000);

                Console.WriteLine(" {0} of {1} iterations completed", i + 1, maxCycle);
            }
        }
    }
}
