using System;
using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;

namespace WaitingSynchronously
{
    class MyDownloadString
    {
        Stopwatch sw = new Stopwatch();

        public void DoRun()
        {
            sw.Start();

            Task<int> t1 = CountCharactersAsync(1, "http://www.microsoft.com");
            Task<int> t2 = CountCharactersAsync(2, "http://www.illustratedcsharp.com");

            Task<int>[] tasks = { t1, t2 };
            // 此处使用WaitAll和WaitAny会得到不同的结果
            Task.WaitAny(tasks);

            Console.WriteLine("Task1:  {0}Finished.", t1.IsCompleted ? "" : "Not");
            Console.WriteLine("Task2:  {0}Finished.", t2.IsCompleted ? "" : "Not");

            Console.ReadKey();
        }

        private async Task<int> CountCharactersAsync(int id, string uri)
        {
            WebClient wc = new WebClient();

            string result = await wc.DownloadStringTaskAsync(new Uri(uri));
            Console.WriteLine("\tCall {0} Completed:{1, 4:N0} ms", id, sw.Elapsed.TotalMilliseconds);

            return result.Length;
        }
    }
    class WaitingSynchronously
    {
        static void Main(string[] args)
        {
            MyDownloadString mds = new MyDownloadString();
            mds.DoRun();
        }
    }
}
