using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace TaskDelay
{
    class DelaySimple
    {
        Stopwatch sw = new Stopwatch();
        public void DoRun()
        {
            Console.WriteLine("Caller: Before Call.");
            ShowDelayAsync();
            Console.WriteLine("Caller: After Call.");
        }

        private async void ShowDelayAsync()
        {
            sw.Start();
            Console.WriteLine(" Before Delay: {0}", sw.ElapsedMilliseconds);
            // 使用Delay()方法不会阻塞当前线程
            await Task.Delay(3000);
            Console.WriteLine(" After Delay: {0}", sw.ElapsedMilliseconds);
        }
    }
    class TaskDelay
    {
        static void Main(string[] args)
        {
            DelaySimple ds = new DelaySimple();
            ds.DoRun();

            Console.ReadKey();
        }
    }
}
